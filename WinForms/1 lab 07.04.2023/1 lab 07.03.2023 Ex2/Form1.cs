using System;
using System.Collections.Generic;
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
                //string strSelected = this.listBox1.SelectedItem.ToString();
                //string[] strs = strSelected.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //string strDel = String.Join("", strs);

                this.listBox1.Items.Remove(this.listBox1.SelectedItem);

                //this.textBox1.Text = strs[0];
                //this.textBox4.Text = strs[1];
                //this.textBox6.Text = strs[2];
                //this.maskedTextBox1.Text = strs[3];
            }
            //if (selected != null)
            //{
            //string strSelected = selected.SelectedItem.ToString();
            //MessageBox.Show(this.listBox1.SelectedItem.ToString());
            //this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            //}
            //else MessageBox.Show("Вы ничего не выбрали в поле. Попробуйте ещё раз", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (this.listBox1.SelectedItem != null)
            //{
            //    this.listBox1.Items.Remove(this.listBox1.SelectedItem);
            //}
            //else MessageBox.Show("Вы ничего не выбрали в поле. Попробуйте ещё раз", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Human(string Name, string Surname, string Email, string Phone)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Phone = Phone;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Email} {Phone}";
        }
    }
}
