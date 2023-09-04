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
    public partial class Edit : Form
    {
        Form1 parentForm;
        public Edit(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

            foreach (var item in parentForm.cc.arr)
            {
                listBoxSelected.Items.Add(item.Name);
            }
        }

        private void listBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBoxSelected.SelectedItem.ToString();

            foreach (var item in parentForm.cc.arr)
            {
                if (item.Name == textBox1.Text) textBoxPriceForProduct.Text = item.Price.ToString();
            }
        }
    }
}
