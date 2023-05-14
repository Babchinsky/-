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
            // Получаем первый день месяца
            CultureInfo culture = new CultureInfo("en-US");
            string monthName = culture.DateTimeFormat.GetMonthName(month);
            labelMonthYear.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            // Получаем кол-во дней в месяце
            int days = DateTime.DaysInMonth(year, month);
            // Конвертируем начальный день недели в int
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));



            #region pre and next Months, Years 

            int daysInCalendar = 42;
            int preMonth = month;
            int yearOfPreMonth = year;

            if (month == 1)
            {
                yearOfPreMonth--;
                preMonth = 12;
            }
            else preMonth--;

            int nextMonth = month;
            int yearOfNextMonth = year;

            if (month == 12)
            {
                yearOfNextMonth++;
                nextMonth = 1;
            }
            else nextMonth++;

            #endregion



            // Дни прошлого месяца
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();

                int daysInPreMonth = DateTime.DaysInMonth(yearOfPreMonth, preMonth);

                userControlBlank.Days(daysInPreMonth - dayOfTheWeek + i + 1);

                LayPanDayContainer.Controls.Add(userControlBlank);
            }

            // Дни этого месяца
            for (int i = 1;i <= days; i++) 
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                LayPanDayContainer.Controls.Add(userControlDays);
            }

            // Дни следующего месяца
            for (int i = LayPanDayContainer.Controls.Count, j = 1; i < daysInCalendar; i++, j++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();

                int daysInNextMonth = DateTime.DaysInMonth(yearOfNextMonth, nextMonth);

                userControlBlank.Days(j);

                LayPanDayContainer.Controls.Add(userControlBlank);
            }
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
