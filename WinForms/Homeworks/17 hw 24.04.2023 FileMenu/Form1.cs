using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace FileMenu
{

   
    public partial class Form1 : Form
    {

        ImageList image_list1 = new ImageList();
        Icon icon;
        Thread thread = null;
        string pathToFolder = "C:\\";

        List<string> FilesFormat = new List<string> { "",".JPG", ".DOC", ".TXT", "HTML" };
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  listBox1.Items.Add("New");
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathToFolder = folderBrowserDialog1.SelectedPath;
                textBox2.Text = pathToFolder;
            }
        }

        public void Find()
        {
            string[] astrFiles = Directory.GetFiles(pathToFolder);
            if (textBox1.Text == "")
            {

                // listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
                foreach (string file in astrFiles)
                {
                    if (file.ToUpper().EndsWith(FilesFormat[comboBox1.SelectedIndex]))
                    {
                        listBox1.Items.Add(file);
                    }

                }
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("Nothing found");
                }
            }
            else
            {


                foreach (string file in astrFiles)
                {
                    if (comboBox1.SelectedIndex != 0)
                    {
                        if (file.ToUpper().EndsWith(textBox1.Text + FilesFormat[comboBox1.SelectedIndex]))
                        {
                            listBox1.Items.Add(file);
                        }
                    }
                    else
                    {
                        if (file.ToUpper().Contains(textBox1.Text))
                        {
                            listBox1.Items.Add(file);
                        }
                    }

                }
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("Nothing found");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Empty field used default");
            }


            listBox1.Items.Clear();
            thread = new Thread(new ThreadStart(Find));
            thread.IsBackground = true;
            thread.Start();
        }

    
    }
}
