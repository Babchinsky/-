using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terminal
{
    public partial class Form2 : Form
    {
        public Form1 ParentForm { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Pessanger item in ParentForm.pessanger)
            {
                if (item.RaceNumber == textBox1.Text)
                {
                    listBox1.Items.Add(item);
                }

            }
        }
    }
}
