using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Windows.Controls.Primitives;

namespace Gallery
{
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private System.Windows.Point startPoint;

        public ObservableCollection<string> Photos { get; set; }
        private int currentPhotoIndex = 0;
        private string author = "Author";
        public MainWindow()
        {
            InitializeComponent();
            Photos = new ObservableCollection<string>();
            PhotosListBox.DataContext = this; // Привязываем DataContext к текущему экземпляру окна
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

        private double GetImageSizeInMegabytes(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            long fileSizeInBytes = fileInfo.Length;

            // Конвертируем байты в мегабайты и округляем до десятых
            double fileSizeInMegabytes = Math.Round((double)fileSizeInBytes / (1024 * 1024), 1);

            return fileSizeInMegabytes;
        }
        private double GetImageSizeInKilobytes(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            long fileSizeInBytes = fileInfo.Length;

            // Конвертируем байты в килобайты и округляем до десятых
            double fileSizeInKilobytes = Math.Round((double)fileSizeInBytes / 1024, 1);

            return fileSizeInKilobytes;
        }

        private string GetImageFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }

        private string GetImageAuthor(string filePath)
        {
            //try
            //{
            //    BitmapDecoder decoder = BitmapDecoder.Create(new Uri(filePath), BitmapCreateOptions.None, BitmapCacheOption.Default);
            //    BitmapMetadata metadata = decoder.Metadata as BitmapMetadata;

            //    if (metadata != null && metadata.Author != null)
            //    {
            //        if (metadata.Author.Count > 0)
            //        {
            //            // If there are multiple authors, return the first one
            //            return author;
            //        }
            //        else
            //        {
            //            // If there is only one author, return it
            //return author;
            //}
            //}
            //}
            //catch (Exception ex)
            //{
            //    // Handle errors
            //    Console.WriteLine($"Error getting image author: {ex.Message}");
            //}

            // Return an empty string if author information is not found
            return author;
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

            FileName.Text = GetImageFileName(FilePath).ToString();
            Size.Text = GetImageSizeInKilobytes(FilePath).ToString() + "KB";
            Author.Text = GetImageAuthor(FilePath).ToString();
            Stars.Visibility = Visibility.Visible;
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
                FileName.Text = GetImageFileName(selectedImagePath).ToString();
                Size.Text = GetImageSizeInKilobytes(selectedImagePath).ToString() + "KB";
                Author.Text = GetImageAuthor(selectedImagePath).ToString();
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
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Проверяем, является ли клик кнопкой закрытия
                if (e.OriginalSource == CloseButton)
                {
                    // Клик на кнопке закрытия, не вызываем DragMove()
                    CloseButton_Click(null, null);
                    return;
                }

                // Проверяем, является ли клик кнопкой закрытия
                if (e.OriginalSource == MaximizeButton)
                {
                    RestoreButton_Click(null, null);
                    // Клик на кнопке закрытия, не вызываем DragMove()
                    return;
                }

                // Проверяем, является ли клик кнопкой сворачивания
                if (e.OriginalSource == MinimizeButton)
                {
                    // Клик на кнопке сворачивания, не вызываем DragMove()
                    MinimizeButton_Click(null, null);
                    return;
                }

                // Клик произошел вне кнопок закрытия и сворачивания, вызываем DragMove()
                DragMove();
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

        private void Star_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton clickedStar = (ToggleButton)sender;
            int rating = int.Parse(clickedStar.Tag.ToString());

            // Закрашиваем все звезды до выбранной
            for (int i = 1; i <= 5; i++)
            {
                ToggleButton star = (ToggleButton)FindName($"star{i}");
                if (i <= rating)
                {
                    star.IsChecked = true;
                }
                else
                {
                    star.IsChecked = false;
                }
            }
        }
    }
}