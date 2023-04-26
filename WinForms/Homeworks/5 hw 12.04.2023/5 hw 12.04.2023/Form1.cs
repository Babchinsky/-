using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_hw_12._04._2023
{
    public partial class Form1 : Form
    {
        string pathToFolder = "C:\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathToFolder = folderBrowserDialog1.SelectedPath;
                textBox1.Text = pathToFolder;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileExtension = this.textBox2.Text;
            string[] astrFiles = Directory.GetFiles(pathToFolder);

            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
            {
                if (file.Contains(fileExtension)) listBox1.Items.Add(file);
            }
        }
    }
}
