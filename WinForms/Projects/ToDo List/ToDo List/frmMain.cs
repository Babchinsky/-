using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class frmMain : Form
    {
        int month, year;
        UserControlDays userControlDays;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DisplayDays();
        }

        private void DisplayDays()
        {
            // Lets get the first day of the month
            CultureInfo culture = new CultureInfo("en-US");
            string monthName = culture.DateTimeFormat.GetMonthName(month);


            DateTime startOfTheMonth = new DateTime(year, month, 1);
            // Get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // Convert the start of the month to integer
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            
            // first lets create a blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                LayPanDayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1;i <= days; i++) 
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                LayPanDayContainer.Controls.Add(userControlDays);
            }
            labelMonthYear.Text = monthName + " " + year; 
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            LayPanDayContainer.Controls.Clear();
            
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else month--;

            
            DisplayDays();
            //MessageBox.Show(string.Format(month.ToString() + " " + year.ToString()));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LayPanDayContainer.Controls.Clear();
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else month++;

            
            DisplayDays();
            //MessageBox.Show(string.Format(month.ToString() + " " + year.ToString()));
        }
    }
}
