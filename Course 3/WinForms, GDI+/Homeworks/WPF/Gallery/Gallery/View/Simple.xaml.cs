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

namespace Gallery
{
    public partial class Simple : Page
    {
        int i = 1;
        public Simple()
        {
            InitializeComponent();
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 6) i = 1;

            picHolder.Source = new BitmapImage(new Uri(@"Pictures/" + i +".jpg", UriKind.Relative));
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1) i = 6;
            picHolder.Source = new BitmapImage(new Uri(@"Pictures/" + i + ".jpg", UriKind.Relative));
        }
    }
}
