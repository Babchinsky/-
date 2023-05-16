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
        private int month, year;
        string userEmail;
        private RadioButton[] radioBtnsDaysInCalendar = new RadioButton[42];

        public frmMain(string email)
        {
            InitializeComponent();
            this.userEmail = email;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Загоняю каждую кнопку в массив кнопок
            for (int i = 0; i < 42; i++)
            {
                string rButtonName = "radioButton" + (i + 1);
                RadioButton rButton = Controls.Find(rButtonName, true).FirstOrDefault() as RadioButton;

                if (rButton != null)
                {
                    radioBtnsDaysInCalendar[i] = rButton;
                    //MessageBox.Show(radioBtnsDaysInCalendar[i].Name);
                }
                else
                {
                    // Обработка ошибки, если кнопка не найдена
                }
            }


            labelAccount.Text = userEmail;

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DisplayDays();

            //listView1.ColorStyle.TransparencyLevel = TransparencyLevel.Full;

        }

        public void ClearDays()
        {
            LayPanDayContainer.Controls.Clear();
        }

        public void DisplayDays()
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



            #region pre Month, YearOfPreMonth 

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
            int idOfRadButton = 0;

            // Дни прошлого месяца
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                radioBtnsDaysInCalendar[idOfRadButton].Enabled = false;
                int daysInPreMonth = DateTime.DaysInMonth(yearOfPreMonth, preMonth);
                //radioBtnsDaysInCalendar[idOfRadButton].ForeColor = Color.FromArgb(204, 204, 179);
                radioBtnsDaysInCalendar[idOfRadButton].ForeColor = Color.Gainsboro;
                //radioBtnsDaysInCalendar[idOfRadButton].BackColor = Color.FromArgb(39, 39, 58);
                radioBtnsDaysInCalendar[idOfRadButton].BackColor = Color.Gray;
                radioBtnsDaysInCalendar[idOfRadButton++].Text = (daysInPreMonth - dayOfTheWeek + i + 1).ToString();
            }

            // Дни этого месяца
            for (int i = 1; i <= days; i++)
            {
                radioBtnsDaysInCalendar[idOfRadButton].Enabled = true;
                radioBtnsDaysInCalendar[idOfRadButton].Cursor = Cursors.Hand;
                radioBtnsDaysInCalendar[idOfRadButton].Text = i.ToString();
                radioBtnsDaysInCalendar[idOfRadButton].BackColor = Color.Gainsboro;
                radioBtnsDaysInCalendar[idOfRadButton++].ForeColor = Color.FromArgb(51, 51, 76);
            }

            int step = idOfRadButton;

            // Дни следующего месяца
            for (int i = step, j = 1; i < daysInCalendar; i++, j++)
            {
                radioBtnsDaysInCalendar[idOfRadButton].Enabled = false;
                //radioBtnsDaysInCalendar[idOfRadButton].ForeColor = Color.FromArgb(204, 204, 179);
                radioBtnsDaysInCalendar[idOfRadButton].ForeColor = Color.Gainsboro;
                //radioBtnsDaysInCalendar[idOfRadButton].BackColor = Color.FromArgb(39, 39, 58);
                radioBtnsDaysInCalendar[idOfRadButton].BackColor = Color.Gray;
                radioBtnsDaysInCalendar[idOfRadButton++].Text = j.ToString();
            }
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            //LayPanDayContainer.Controls.Clear();

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
            //LayPanDayContainer.Controls.Clear();
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else month++;


            DisplayDays();
            //MessageBox.Show(string.Format(month.ToString() + " " + year.ToString()));
        }



        private void rBtns_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedControl = sender as RadioButton;

            for (int i = 0; i < radioBtnsDaysInCalendar.Length; i++)
            {
                if (radioBtnsDaysInCalendar[i].Enabled == true)
                {
                    radioBtnsDaysInCalendar[i].ForeColor = Color.FromArgb(39, 39, 58);
                }
            }

            clickedControl.ForeColor = Color.DarkRed;
            rbtnSelectedDay.Checked = true;
        }

        private void rbtnMenus_Enter(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            // Сохраняем исходный цвет фона
            Color originalBackColor = radioButton.BackColor;

            // Устанавливаем пользовательский цвет фона, чтобы предотвратить изменение при наведении
            radioButton.BackColor = originalBackColor;
        }



        private void btnAcExit_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
