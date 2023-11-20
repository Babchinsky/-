using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LastDatabase
{
    public class M_CurrentUser : ObservableObject
    {
        private static M_CurrentUser _instance;
        public static M_CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new M_CurrentUser();
                return _instance;
            }
        }
        public int UID { get; set; }
        public List<string> Friends { get; set; } = new();

        public string Email;
        public string Password;
        public string Name;
        public string Image;
        public string Color;

        private M_CurrentUser()
        {

        }
    }
}
