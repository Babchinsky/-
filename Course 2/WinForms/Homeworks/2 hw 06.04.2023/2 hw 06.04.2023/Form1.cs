using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_hw_06._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;

            if (r == radioButton1)
            {
                progressBar1.Value += 10;
                groupBox1.Enabled = false;
            }

            if (r == radioButton6)
            {
                progressBar1.Value += 10;
                groupBox2.Enabled = false;
            }

            if (r == radioButton12)
            {
                progressBar1.Value += 10;
                groupBox3.Enabled = false;
            }

            if (r == radioButton13)
            {
                progressBar1.Value += 10;
                groupBox4.Enabled = false;
            }

            if (r == radioButton17)
            {
                progressBar1.Value += 10;
                groupBox5.Enabled = false;
            }


            ////////////////////////////



            if (r == radioButton34)
            {
                progressBar1.Value += 10;
                groupBox9.Enabled = false;
            }

            if (r == radioButton31)
            {
                progressBar1.Value += 10;
                groupBox8.Enabled = false;
            }

            if (r == radioButton25)
            {
                progressBar1.Value += 10;
                groupBox7.Enabled = false;
            }

            if (r == radioButton24)
            {
                progressBar1.Value += 10;
                groupBox6.Enabled = false;
            }

            if (progressBar1.Value == 100) MessageBox.Show("Ура!!!", "Вы выиграли");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox r = (CheckBox)sender;

            if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                groupBox10.Enabled = false;
                progressBar1.Value += 10;
            }

            if (progressBar1.Value == 100) MessageBox.Show("Ура!!!", "Вы выиграли");
        }

        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                // Здесь можно добавить действия, которые нужно выполнить, когда значение прогресс бара достигает 100
                MessageBox.Show("Процесс завершен!");
            }
        }
    }
}
