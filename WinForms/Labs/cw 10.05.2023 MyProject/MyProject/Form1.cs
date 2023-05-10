using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw_10._05._2023_dll.MyStudent;
using static System.Windows.Forms.ListView;

namespace MyProject
{
    public partial class Form1 : Form
    {
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            students.Add(new Student("Ivan",20,"ItStep"));
            students.Add(new Student("Oleg", 23, "Politex"));
            students.Add(new Student("Irina", 22, "ItStep"));

            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Возраст");
            listView1.Columns.Add("Университет");
            listView1.View = View.Details;
            foreach (var a in students)
            {
                ListViewItem rez = listView1.Items.Add(a.Name);
                rez.SubItems.Add(a.Age.ToString());
                rez.SubItems.Add(a.Academy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
           {
                Student added = new Student(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
                students.Add(added);

                ListViewItem rez = listView1.Items.Add(added.Name);
                rez.SubItems.Add(added.Age.ToString());
                rez.SubItems.Add(added.Academy);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            { 
                if (listView1.SelectedItems.Count > 0)
                {
                    contextMenuStrip1.Show(this, e.Location);
                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                Student deleted = new Student(selectedItem.SubItems[0].Text, Convert.ToInt32(selectedItem.SubItems[1].Text), selectedItem.SubItems[2].Text);
                //MessageBox.Show(string.Format(deleted.Name + ' ' + deleted.Age + ' ' + deleted.Academy));

                // Удаляю из Списка в коде
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == deleted.Name && students[i].Age == deleted.Age && students[i].Academy == deleted.Academy)
                    {
                        students.Remove(students[i]);
                    }
                }
                    
              

                // Удаляю из интерфейса
                listView1.Items.Remove(selectedItem);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Point cursorPos = listView1.PointToClient(Cursor.Position);
            int cursorX = cursorPos.X;
            int cursorY = cursorPos.Y;

            // Определите позицию открытия контекстного меню справа от курсора
            int menuX = listView1.PointToScreen(new Point(cursorX, cursorY)).X;
            int menuY = listView1.PointToScreen(new Point(cursorX, cursorY)).Y;

            // Откройте контекстное меню по заданной позиции
            contextMenuStrip1.Show(menuX, menuY);
        }
    }
}
