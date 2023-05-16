using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
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
            DisplayEvents();
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

        public void ClearEvents()
        {
            panelEvents.Controls.Clear();
        }
        public void DisplayEvents()
        {
            //Panel panelEvent2 = new Panel();
            //panelEvent2.Height = 40;
            //panelEvent2.Width = 830;
            //panelEvent2.BackColor = Color.White;

            //EventControl eventControl;



            //for (int i = 0; i < 10; i++)
            //{

            //    eventControl = new EventControl(i.ToString());
            //    eventControl.Location = new Point(10, i * 40);
            //    panelEvents.Controls.Add(eventControl);
            //}

            //string imagePath = Path.Combine(Application.StartupPath, "src", "star_unchecked.png");
            //Bitmap image = new Bitmap(imagePath);


            for (int i = 0; i < 3; i++)
            {


                Panel panel = new Panel();
                panel.Width = 825;
                panel.Height = 40;
                panel.Location = new Point(10, i * 50);
                //panel.Margin = new Padding(0, 10, 0, 0);
                panel.BackColor = Color.White;
                //panel.Dock = DockStyle.Top;

                panelEvents.Controls.Add(panel);

                CheckBox chkDone = new CheckBox();
                TextBox txtName = new TextBox();
                TextBox txtDate = new TextBox();
                TextBox txtTime = new TextBox();
                CheckBox chkFavourite = new CheckBox();

                chkDone.Location = new Point(13, 15);
                chkDone.Width = 15;
                chkDone.Height = 14;
                panel.Controls.Add(chkDone);


                txtName.Text = i.ToString();
                txtName.BackColor = SystemColors.Window;
                txtName.ForeColor = Color.Black;
                txtName.Location = new Point(34, 9);
                txtName.Width = 439;
                txtName.Height = 25;
                panel.Controls.Add(txtName);

                txtDate.Text = i.ToString();
                txtDate.BackColor = SystemColors.Window;
                txtDate.ForeColor = Color.Black;
                txtDate.Location = new Point(479, 9);
                txtDate.Width = 148;
                txtDate.Height = 25;
                panel.Controls.Add(txtDate);

                txtTime.Text = i.ToString();
                txtTime.BackColor = SystemColors.Window;
                txtTime.ForeColor = Color.Black;
                txtTime.Location = new Point(634, 9);
                txtTime.Width = 148;
                txtTime.Height = 25;
                panel.Controls.Add(txtTime);

                chkFavourite.Location = new Point(788, 10);
                chkFavourite.Width = 25;
                chkFavourite.Height = 25;
                //chkFavourite.FlatStyle = FlatStyle.Flat;

                //chkFavourite.BackgroundImage = image;
                
                panel.Controls.Add(chkFavourite);


                //TextBox txt1 = new TextBox();
                //TextBox txt2 = new TextBox();
                //TextBox txt3 = new TextBox();
                ////TextBox txt4 = new TextBox();
                //CheckBox chk1 = new CheckBox();

                //txt1.Text = i.ToString();
                //txt1.BackColor = SystemColors.Window;
                //txt1.ForeColor = Color.Black;
                //txt1.Location = new Point(7, 9);
                //txt1.Width = 367;
                //txt1.Height = 25;
                //panel.Controls.Add(txt1);


                //txt2.Text = i.ToString();
                //txt2.BackColor = SystemColors.Window;
                //txt2.ForeColor = Color.Black;
                //txt2.Location = new Point(380, 9);
                //txt2.Width = 169;
                //txt2.Height = 25;
                //panel.Controls.Add(txt2);

                //txt3.Text = i.ToString();
                //txt3.BackColor = SystemColors.Window;
                //txt3.ForeColor = Color.Black;
                //txt3.Location = new Point(555, 9);
                //txt3.Width = 119;
                //txt3.Height = 25;
                //panel.Controls.Add(txt3);

                ////txt4.Text = i.ToString();
                ////txt4.BackColor = SystemColors.Window;
                ////txt4.ForeColor = Color.Black;
                ////txt4.Location = new Point(680, 9);
                ////txt4.Width = 136;
                ////txt4.Height = 25;
                ////panel.Controls.Add(txt4);

                //chk1.Location = new Point(748, 15);
                //chk1.Width = 15;
                //chk1.Height = 14;
                //panel.Controls.Add(chk1);
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
            ClearEvents();
            //MessageBox.Show(string.Format(month.ToString() + " " + year.ToString()));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayEvents();
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
