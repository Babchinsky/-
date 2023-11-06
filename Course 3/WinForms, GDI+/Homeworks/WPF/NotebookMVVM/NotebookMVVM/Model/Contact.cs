using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookMVVM.Model
{
    public class Contact
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Contact()
        {
            FullName = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
        }
    }
}
