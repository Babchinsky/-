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


namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PhotoCollection Photos;
        public Photo _photo;
        public static bool needAngle = false;
        public static bool needSigma = false;
        public static bool needMatrixSize = false;
        public static bool needThreshold = false;
        public static bool needDataForGaborFilter = false;
        public static bool needBrushSize = false;
        public static bool needRadius = false;
        public MainWindow()
        {
            InitializeComponent();
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
        void SaveUsingEncoder(BitmapEncoder encoder, string format)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            switch (format)
            {
                case ".jpg":
                    saveFileDialog.Filter = "JPG|*.jpg";
                    break;
                case ".png":
                    saveFileDialog.Filter = "PNG|*.png";
                    break;
                case ".bmp":
                    saveFileDialog.Filter = "BMP|*.bmp";
                    break;
            }
            if (saveFileDialog.ShowDialog() == true)
            {
                encoder.Frames.Add(_photo.Image);
                using (var stream = File.Create(saveFileDialog.FileName))
                {
                    encoder.Save(stream);
                }
            }
        }
        private void Refresh()
        {
            if (PhotosListBox.SelectedItem != null)
            {
                _photo = (Photo)PhotosListBox.SelectedItem;
                ViewedPhoto.Source = _photo.Image;
                SIG.Title = "Gallery: " + _photo.Source;
            }
        }

        private void OnPhotoMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Refresh();
        }

        private void Update(string FilePath)
        {
            //Photos = new PhotoCollection();
            //if (Photos == null) MessageBox.Show("Null");
            Photos.Path = FilePath.Remove(FilePath.LastIndexOf('\\') + 1);
            for (int i = 0; i < Photos.Count; ++i)
            {
                if (Photos[i].Source.Equals(FilePath))
                {
                    PhotosListBox.SelectedItem = Photos[i]; 
                    break;
                }
            }
            Refresh();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Update(_photo.Source);
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                Update(openFileDialog.FileName);
        }

        private void SaveToJpg(object sender, RoutedEventArgs e)
        {
            SaveUsingEncoder(new JpegBitmapEncoder(), ".jpg");
        }

        void SaveToPng(object sender, RoutedEventArgs e)
        {
            SaveUsingEncoder(new PngBitmapEncoder(), ".png");
        }

        void SaveToBmp(object sender, RoutedEventArgs e)
        {
            SaveUsingEncoder(new BmpBitmapEncoder(), ".bmp");
        }
    }
}
