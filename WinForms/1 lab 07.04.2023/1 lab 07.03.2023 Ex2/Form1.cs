using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab_07._03._2023_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(this.textBox1.Text) && !String.IsNullOrEmpty(this.textBox4.Text) && !String.IsNullOrEmpty(this.textBox6.Text) && !String.IsNullOrEmpty(this.maskedTextBox1.Text))
            {
                Human human = new Human(this.textBox1.Text, this.textBox4.Text, this.textBox6.Text, this.maskedTextBox1.Text);
                string strHuman = human.ToString();

                if (!this.listBox1.Items.Contains(strHuman))
                    this.listBox1.Items.Add(strHuman);
               
                else MessageBox.Show("Список уже хранит этого человека");
            }
            else MessageBox.Show("Вы ничего не указли в поле. Попробуйте ещё раз", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                string strSelected = this.listBox1.SelectedItem.ToString();
                string[] strs = strSelected.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.textBox1.Text = strs[0];
                this.textBox4.Text = strs[1];
                this.textBox6.Text = strs[2];
                this.maskedTextBox1.Text = strs[3];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);

                if (!String.IsNullOrEmpty(this.textBox1.Text) && !String.IsNullOrEmpty(this.textBox4.Text) && !String.IsNullOrEmpty(this.textBox6.Text) && !String.IsNullOrEmpty(this.maskedTextBox1.Text))
                {
                    Human human = new Human(this.textBox1.Text, this.textBox4.Text, this.textBox6.Text, this.maskedTextBox1.Text);
                    string strHuman = human.ToString();

                    if (!this.listBox1.Items.Contains(strHuman))
                        this.listBox1.Items.Add(strHuman);

                    else MessageBox.Show("Список уже хранит этого человека");
                }
                else MessageBox.Show("Вы ничего не указли в поле. Попробуйте ещё раз", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HumanCollection people = new HumanCollection();
            Human human;

            if (this.listBox1.Items.Count != 0)
            {
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    string str = this.listBox1.Items[i].ToString();
                    string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    human = new Human(strs[0], strs[1], strs[2], strs[3]);
                    people.Add(human);
                }
            }

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, people.ToString());
            MessageBox.Show("Файл сохранен");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HumanCollection people = new HumanCollection();
            Human human;

            if (this.listBox1.Items.Count != 0)
            {
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    string str = this.listBox1.Items[i].ToString();
                    string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    human = new Human(strs[0], strs[1], strs[2], strs[3]);
                    people.Add(human);
                }
            }

            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем данные в XML-файл
            people.SaveToXml(filename);
            MessageBox.Show("Файл сохранен");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            // открытие файла
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;

            // читаем данные из XML-файла
            HumanCollection people = HumanCollection.LoadFromXml(filename);
            MessageBox.Show("Файл открыт");


            foreach (Human human in people.people)
            {
                listBox1.Items.Add(human.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            MessageBox.Show("Файл открыт");

            string[] lines = fileText.Split(new char[] { '\n'}, StringSplitOptions.RemoveEmptyEntries);

            Human human = new Human();

            for (int i = 0; i < lines.Length; i += 4)
            {
                human.Name = lines[i].Split(':')[1];
                human.Surname = lines[i + 1].Split(':')[1];
                human.Email = lines[i + 2].Split(':')[1];
                human.Phone = lines[i + 3].Split(':')[1];

                listBox1.Items.Add(human.ToString());
            }
        }
    }
}
