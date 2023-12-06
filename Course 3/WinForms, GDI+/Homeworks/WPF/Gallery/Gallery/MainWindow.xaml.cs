using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public PhotoCollection Photos;
        //public Photo _photo;

        public ObservableCollection<string> Photos { get; set; }
        public MainWindow()
        {
            //InitializeComponent();
            //Photos = new ObservableCollection<string>();

            InitializeComponent();
            Photos = new ObservableCollection<string>();
            //Photos.Add("C:\\Wallpapers\\1.jpg"); // Пример добавления элемента
            PhotosListBox.DataContext = this; // Привязываем DataContext к текущему экземпляру окна
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
            // Применяю фотографию к главному окну
            Uri uri = new Uri(FilePath, UriKind.Absolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            ViewedPhoto.Source = bitmapImage;


            string folderPath = System.IO.Path.GetDirectoryName(FilePath);
            string[] imageFiles = GetImageFilesInFolder(folderPath);
            foreach (string imageFile in imageFiles)
            {
                Photos.Add(imageFile);
            }
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
           
        }

        void SaveUsingEncoder(BitmapEncoder encoder, string format)
        {

        }

        private void SaveToJpg(object sender, RoutedEventArgs e)
        {
           
        }

        void SaveToPng(object sender, RoutedEventArgs e)
        {
        }

        void SaveToBmp(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
