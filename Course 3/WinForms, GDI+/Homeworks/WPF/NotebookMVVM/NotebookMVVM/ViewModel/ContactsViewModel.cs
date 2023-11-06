using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NotebookMVVM.ViewModel
{
    public class ContactsViewModel : DependencyObject
    {


        public int FilterText
        {
            get { return (int)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(int), typeof(ContactsViewModel), new PropertyMetadata(""));


    }
}
