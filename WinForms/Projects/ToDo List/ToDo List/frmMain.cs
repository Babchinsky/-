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
        string userEmail;
        private int month, year;
        private RadioButton[] radioBtnsDaysInCalendar = new RadioButton[42];


        List<Event> eventsInFile;
        int eventsCount;

        EventFileManager eventFileManager;
        string filepath;



        int eventsOnScreen;











        public frmMain(string email)
        {
            InitializeComponent();
            this.userEmail = email;

            filepath = userEmail + ".json";
            eventsOnScreen = 0;

            //eventFileManager.Wr\
            CreateNewEventsFileWithExample();

            eventFileManager = new EventFileManager(filepath);


            if (!File.Exists(filepath))
            {
                eventFileManager.CreateEmptyFile();
                eventsCount = 0;
            }
            else
            {
                eventsInFile = eventFileManager.ReadFile();
                eventsCount = eventsInFile.Count;
            }

            
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
            DisplayEvents(eventsInFile);
        }

        public void CreateNewEventsFileWithExample()
        {
            eventsInFile = new List<Event>
            {
                new Event(DateTime.Parse("2023-05-16"), "Meeting", false, true),
                new Event(DateTime.Parse("2023-05-17"), "Birthday Party", true, false),
                new Event(DateTime.Parse("2023-05-18"), "Conference", false, true)
            };

            EventFileManager eventFileManager = new EventFileManager(filepath);
            eventFileManager.WriteToFile(eventsInFile);
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
            eventsOnScreen = 0;
            panelEvents.Controls.Clear();
        }

        public void DisplayEvents(List<Event> events)
        {
            foreach (var item in events)
            {
                AddToInterfaceEvent(item.IsDone, item.Name, item.Date, item.IsFavourite);
            }
        }

        public void AddToInterfaceEvent(bool isDone, string name, DateTime dateAndTime, bool isFavourite)
        {
            Panel panel = new Panel();
            panel.Width = 810;
            panel.Height = 40;
            panel.Location = new Point(10, eventsOnScreen * 50);
            //panel.Margin = new Padding(0, 10, 0, 0);
            panel.BackColor = Color.Gainsboro;
            //panel.Dock = DockStyle.Top;

            panelEvents.Controls.Add(panel);

            CheckBox chkDone = new CheckBox();
            TextBox txtName = new TextBox();
            TextBox txtDate = new TextBox();
            TextBox txtTime = new TextBox();
            CheckBox chkFavourite = new CheckBox();

            if (isDone) chkDone.Checked = true;
            else chkFavourite.Checked = false;
            chkDone.Location = new Point(13, 15);
            chkDone.Width = 15;
            chkDone.Height = 14;
            panel.Controls.Add(chkDone);


            
            txtName.Text = name;
            txtName.BackColor = SystemColors.Window;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(34, 12);
            txtName.Width = 439;
            txtName.Height = 25;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Multiline = true;
            txtName.BackColor = Color.Gainsboro;
            panel.Controls.Add(txtName);

            txtDate.Text = dateAndTime.ToString("dd-MM-yyyy");
            txtDate.BackColor = SystemColors.Window;
            txtDate.ForeColor = Color.Black;
            txtDate.Location = new Point(479, 12);
            txtDate.Width = 148;
            txtDate.Height = 25;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Multiline = true;
            txtDate.BackColor = Color.Gainsboro;
            panel.Controls.Add(txtDate);

            txtTime.Text = dateAndTime.ToString("t"); ;
            txtTime.BackColor = SystemColors.Window;
            txtTime.ForeColor = Color.Black;
            txtTime.Location = new Point(634, 12);
            txtTime.Width = 148;
            txtTime.Height = 25;
            txtTime.BorderStyle = BorderStyle.None;
            txtTime.Multiline = true;
            txtTime.BackColor = Color.Gainsboro;
            panel.Controls.Add(txtTime);


            if (isFavourite) chkFavourite.Checked = true;
            else chkFavourite.Checked = false;
            chkFavourite.Location = new Point(788, 10);
            chkFavourite.Width = 25;
            chkFavourite.Height = 25;
            panel.Controls.Add(chkFavourite);

            //eventsCount++;
            eventsOnScreen++;
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
            DisplayEvents(eventsInFile);

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

        }

        private void rbtnMenus_Enter(object sender, EventArgs e)
        {
            //RadioButton radioButton = (RadioButton)sender;

            //// Сохраняем исходный цвет фона
            //Color originalBackColor = radioButton.BackColor;

            //// Устанавливаем пользовательский цвет фона, чтобы предотвратить изменение при наведении
            //radioButton.BackColor = originalBackColor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

            for (int i = 0; i < radioBtnsDaysInCalendar.Length; i++)
            {
                radioBtnsDaysInCalendar[i].ForeColor = Color.FromArgb(39, 39, 58);
            }
            ((RadioButton)sender as RadioButton).ForeColor = Color.Maroon;

            if (rbtnSelectedDay.Checked == true)
            {
                rbtnSelectedDay_CheckedChanged(sender,e);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int day = 1;


            foreach (RadioButton radio in  radioBtnsDaysInCalendar)
            {
                if (radio.Checked) day = Convert.ToInt32(radio.Text);
            }
            

            DateTime dateTimeToAdd = new DateTime(year, month, day);

            AddToInterfaceEvent(false, txtBox.Text, dateTimeToAdd, false);
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked == true)
            {
                ClearEvents();
                DisplayEvents(eventsInFile);
            }
        }

        private void rbtnSelectedDay_CheckedChanged(object sender, EventArgs e)
        {
            ClearEvents();

            int day = 1;// по умолчанию
            RadioButton selected;

            foreach (RadioButton radio in radioBtnsDaysInCalendar)
            {
                if (radio.Checked)
                {
                    day = Convert.ToInt32(radio.Text);
                    selected = radio;
                }
            }

            DateTime dateTime = new DateTime(year, month, day);

            List<Event> eventsPerSDay = new List<Event>();

            foreach (var item in eventsInFile)
            {
                if (item.Date == dateTime) eventsPerSDay.Add(item);
            }



            foreach (RadioButton radio in radioBtnsDaysInCalendar)
            {
                if (radio.Checked)
                {
                    if (rbtnSelectedDay.Checked == true)
                    {
                        DisplayEvents(eventsPerSDay);
                    }
                }
            }
            

            
            

            


            

            
        }

        private void rbtnFavourite_CheckedChanged(object sender, EventArgs e)
        {
            ClearEvents();

            List<Event> favouriteEvents = new List<Event>();
            foreach (var item in eventsInFile)
            {
                if (item.IsFavourite == true) favouriteEvents.Add(item);
            }

            DisplayEvents(favouriteEvents);
        }

        private void rbtnDone_CheckedChanged(object sender, EventArgs e)
        {
            ClearEvents();

            List<Event> doneEvents = new List<Event>();
            foreach (var item in eventsInFile)
            {
                if (item.IsDone == true) doneEvents.Add(item);
            }

            DisplayEvents(doneEvents);
        }

        private void rbtnPending_CheckedChanged(object sender, EventArgs e)
        {
            ClearEvents();

            List<Event> pendingEvents = new List<Event>();
            foreach (var item in eventsInFile)
            {
                if (item.Date > DateTime.Now) pendingEvents.Add(item);
            }

            DisplayEvents(pendingEvents);
        }

        private void btnAcExit_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
