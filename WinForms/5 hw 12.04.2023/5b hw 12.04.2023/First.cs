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
    public partial class First : Form
    {
        Form1 parentForm;
        decimal totalPrice = 0;

        public First(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            


            foreach (var item in parentForm.cc.arr)
            {
                comboBoxAllProducts.Items.Add(item.Name);
            }
            comboBoxAllProducts.SelectedIndex = 0;
        }

        private void comboBoxAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPriceForProduct.Text = (parentForm.cc.arr[comboBoxAllProducts.SelectedIndex].Price).ToString();
        }

        private void buttonToSelected_Click(object sender, EventArgs e)
        {
            if (!listBoxSelected.Items.Contains(comboBoxAllProducts.Text))
            {
                listBoxSelected.Items.Add(comboBoxAllProducts.Text);
                totalPrice += Convert.ToDecimal(textBoxPriceForProduct.Text);
                textBoxTotalPrice.Text = totalPrice.ToString();
            }
            else MessageBox.Show("Данный товар уже находится в корзине!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItem != null)
            {
                foreach (var item in parentForm.cc.arr)
                {
                    if (item.Name == listBoxSelected.SelectedItem.ToString())
                    {
                        totalPrice -= item.Price;
                    }
                }
                textBoxTotalPrice.Text = totalPrice.ToString();

                listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
            }
        }
    }
}
