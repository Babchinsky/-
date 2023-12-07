using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Gallery
{
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private System.Windows.Point startPoint;

        public ObservableCollection<string> Photos { get; set; }
        private int currentPhotoIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            Photos = new ObservableCollection<string>();
            //Photos.Add("C:\\Wallpapers\\1.jpg"); // Пример добавления элемента
            PhotosListBox.DataContext = this; // Привязываем DataContext к текущему экземпляру окна


            // Путь к файлу с изображением
            //string imagePath = "C:\\Wallpapers\\1.jpg";

            // Создаем объект BitmapImage и устанавливаем его как источник для ViewedPhoto
            //BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));
            //ViewedPhoto.Source = bitmapImage;
        }
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Minimize_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Maximize_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }


        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Обработка открытия файла
                string selectedFilePath = openFileDialog.FileName;
                // Добавьте свой код обработки файла здесь
            }
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string absolutePath = openFileDialog.FileName;
                LoadAfterOpenFile(absolutePath);
            }
        }

        private string[] GetImageFilesInFolder(string folderPath)
        {
            // Получаем все файлы с указанными расширениями в папке
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".bmp") || file.ToLower().EndsWith(".jpeg"))
                .ToArray();

            return imageFiles;
        }

        private void LoadAfterOpenFile(string FilePath)
        {
            Clear();

            string folderPath = System.IO.Path.GetDirectoryName(FilePath);
            string[] imageFiles = GetImageFilesInFolder(folderPath);
            foreach (string imageFile in imageFiles)
            {
                Photos.Add(imageFile);
            }

            // Устанавливаем выбранное изображение
            PhotosListBox.SelectedItem = FilePath;

            // Применяю фотографию к главному окну
            Uri uri = new Uri(FilePath, UriKind.Absolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            ViewedPhoto.Source = bitmapImage;

            // Прокручиваем к выбранному элементу
            PhotosListBox.ScrollIntoView(PhotosListBox.SelectedItem);
        }

        private void ChangeMainImage(string FilePath)
        {
            // Применяю фотографию к главному окну
            Uri uri = new Uri(FilePath, UriKind.Absolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            ViewedPhoto.Source = bitmapImage;
        }

        private void Clear()
        {
            Photos.Clear();
        }

        private void OnListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PhotosListBox.SelectedItem != null)
            {
                string selectedImagePath = PhotosListBox.SelectedItem.ToString();
                ChangeMainImage(selectedImagePath);
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Photos.Clear();
            PhotosListBox.SelectedIndex = -1;
            ViewedPhoto.Source = null;
        }

        private void SaveAsJpg_Click(object sender, RoutedEventArgs e)
        {
            SaveImageWithEncoder(new JpegBitmapEncoder(), ".jpg");
        }

        private void SaveAsPng_Click(object sender, RoutedEventArgs e)
        {
            SaveImageWithEncoder(new PngBitmapEncoder(), ".png");
        }

        private void SaveAsBmp_Click(object sender, RoutedEventArgs e)
        {
            SaveImageWithEncoder(new BmpBitmapEncoder(), ".bmp");
        }

        private void SaveImageWithEncoder(BitmapEncoder encoder, string fileExtension)
        {
            if (PhotosListBox.SelectedItem != null)
            {
                // Получаем выбранный путь к изображению
                string selectedImagePath = PhotosListBox.SelectedItem.ToString();

                // Создаем BitmapImage из выбранного изображения
                BitmapImage bitmapImage = new BitmapImage(new Uri(selectedImagePath, UriKind.Absolute));

                // Добавляем BitmapFrame с выбранным изображением в кодировщик
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                // Создаем диалог для сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = $"{encoder.GetType().Name} Files|*{fileExtension}|All files (*.*)|*.*";
                saveFileDialog.FileName = System.IO.Path.GetFileNameWithoutExtension(selectedImagePath); // Имя файла по умолчанию

                // Показываем диалог сохранения
                bool? result = saveFileDialog.ShowDialog();

                // Если пользователь выбрал файл и нажал "Сохранить"
                if (result == true)
                {
                    // Получаем выбранный путь для сохранения
                    string savePath = saveFileDialog.FileName;

                    // Сохраняем изображение в файл
                    using (FileStream fileStream = new FileStream(savePath, FileMode.Create))
                    {
                        encoder.Save(fileStream);
                    }
                }
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void UpdateDisplayedPhoto()
        {
            string currentPhotoPath = Photos[currentPhotoIndex];
            // Здесь вы можете использовать currentPhotoPath для обновления вашего интерфейса (например, изменить источник изображения)
            ViewedPhoto.Source = new BitmapImage(new Uri(currentPhotoPath));
            //// Прокручиваем к выбранному элементу
            PhotosListBox.ScrollIntoView(PhotosListBox.SelectedItem);
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            if (Photos.Count == 0) { return; }
            currentPhotoIndex = 0;
            PhotosListBox.SelectedIndex = currentPhotoIndex;
            UpdateDisplayedPhoto();
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            if (Photos.Count == 0) { return; }
            currentPhotoIndex = Photos.Count - 1;
            PhotosListBox.SelectedIndex = currentPhotoIndex;
            UpdateDisplayedPhoto();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (Photos.Count == 0) { return; }
            if (currentPhotoIndex < Photos.Count - 1)
            {
                currentPhotoIndex++;
            }
            else
            {
                // Если индекс на последнем изображении, перейти к первому изображению
                currentPhotoIndex = 0;
            }
            PhotosListBox.SelectedIndex = currentPhotoIndex;
            UpdateDisplayedPhoto();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (Photos.Count == 0) { return; }
            if (currentPhotoIndex > 0)
            {
                currentPhotoIndex--;
            }
            else
            {
                // Если индекс 0, перейти к последнему изображению
                currentPhotoIndex = Photos.Count - 1;
            }
            PhotosListBox.SelectedIndex = currentPhotoIndex;
            UpdateDisplayedPhoto();
        }
    }
}