using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5b_hw_12._04._2023
{

    public partial class Form1 : Form
    {
        //public ComputerComponents computerComponents;
        public ComputerComponents cc;
        public Form1()
        {
           InitializeComponent();
            cc = new ComputerComponents();
            cc.arr = new ComputerComponent[]
            {
                new ComputerComponent("CPU", 199.99m),
                new ComputerComponent("GPU", 499.99m),
                new ComputerComponent("RAM", 99.99m),
                new ComputerComponent("Motherboard", 149.99m),
                new ComputerComponent("Power Supply", 79.99m)
           };

            /*cc.RemoveByName("CPU");*/
            //cc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           First first = new First(this);
           DialogResult res = first.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            DialogResult res = edit.ShowDialog();
        }
    }
}
