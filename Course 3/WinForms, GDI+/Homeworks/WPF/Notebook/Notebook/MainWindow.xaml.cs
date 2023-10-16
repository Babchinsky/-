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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notebook
{
    public partial class MainWindow : Window
    {
        private ContactsViewModel viewModel;
        //private IDataService dataService;

        public MainWindow()
        {
            InitializeComponent();
            //viewModel = new ContactsViewModel();
            //dataService = new DataService();
            DataContext = viewModel;

            // Загрузка данных из файла при запуске
            //viewModel.Contacts = new ObservableCollection<Contact>(dataService.LoadContacts("contacts.json"));
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Сохранение данных в файл при нажатии кнопки
            //dataService.SaveContacts(viewModel.Contacts.ToList(), "contacts.json");
            MessageBox.Show("Данные сохранены.");
        }
    }

}
