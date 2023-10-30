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

namespace Authentification
{
    public partial class MainWindow : Window
    {
        Database db = new Database();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            db.FindUsernameAndPassword(lUsrn.Text, lPsw.ToString());
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void showReg(object sender, RoutedEventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();
            this.Close();
        }
    }
}
