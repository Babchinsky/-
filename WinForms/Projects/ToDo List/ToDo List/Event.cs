using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ToDo_List
{
    public class Event
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public Event() { }
        public Event(DateTime date, string name)
        {
            Date = date;
            Name = name;
        }
    }
}
