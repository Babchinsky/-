using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDatabase
{
    public class DatabaseUser
    {
        // Данные для БД
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public List<string> FriendsName { get; set; }
    }
}
