using _19_hw_26._04._2023_MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _19_hw_26._04._2023_MVC
{
    public partial class View : Form
    {
        Controller controller;
        public View()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 


            if (radioButton1.Checked == true )
            {
                List<Book> result = controller.GetBookByTitle(textBox1.Text);

                for (int i = 0; i < result.Count; i++)
                {
                    listBox1.Items.Add(string.Format(result[i].Name + " (" + result[i].Author + ")"));
                }
            }
            else if (radioButton2.Checked == true )
            {
                List<Book> result = controller.GetBookByAuthor(textBox1.Text);

                for (int i = 0; i < result.Count; i++)
                {
                    listBox1.Items.Add(string.Format(result[i].Name + " (" + result[i].Author + ")"));
                }
            }
            
        }
    }
}
