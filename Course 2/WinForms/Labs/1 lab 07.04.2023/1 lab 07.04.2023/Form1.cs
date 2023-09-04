using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab_07._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            progressBar1.Maximum = 500;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);

            for (int i = 0; i < fileText.Length; i++)
            {
                progressBar1.Value++;
            }

            textBox1.Text = fileText;
            MessageBox.Show("Файл " + filename +" открыт. " +fileText.Length + " / " + progressBar1.Maximum);
        }
    }
}
