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

namespace Authentification
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        //private string name, surname, usrn, psw, sql;
        //private connection conn = new connection();
        //private MySqlCommand cmd;
        Database db = new Database();

        public Register()
        {
            InitializeComponent();
        }

        private void RegisterF(object sender, RoutedEventArgs e)
        {
            db.CheckAndAddUser(rUsrn.Text, rPsw.ToString(), rName.Text, rSurname.Text);
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void showLog(object sender, RoutedEventArgs e)
        {
            MainWindow logForm = new MainWindow();
            logForm.Show();
            this.Close();
        }

    }
}
