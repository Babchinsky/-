using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_hw_11._04._2023_Forms
{
    public partial class EditForm : Form
    {
        MainForm parentForm;
        public EditForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;

            textBox4.Text = parentForm.prices.cafePrices["Хот-дог"].ToString();
            textBox2.Text = parentForm.prices.cafePrices["Бургер"].ToString();
            textBox7.Text = parentForm.prices.cafePrices["Фри"].ToString();
            textBox9.Text = parentForm.prices.cafePrices["Кола"].ToString();

            foreach (var item in parent.prices.fuelPrices)
            {
                this.comboBox1.Items.Add(item.Key);
            }
            this.comboBox1.SelectedIndex = 0;

            textBoxFuelPricePerL.Text = parentForm.prices.fuelPrices[this.comboBox1.Text].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox7.Text) && !String.IsNullOrEmpty(textBox9.Text))
            {
                parentForm.prices.cafePrices["Хот-дог"] = Convert.ToDecimal(textBox4.Text);
                parentForm.prices.cafePrices["Бургер"] = Convert.ToDecimal(textBox2.Text);
                parentForm.prices.cafePrices["Фри"] = Convert.ToDecimal(textBox7.Text);
                parentForm.prices.cafePrices["Кола"] = Convert.ToDecimal(textBox9.Text);
            }

            if (!String.IsNullOrEmpty(textBoxFuelPricePerL.Text))
                parentForm.prices.fuelPrices[comboBox1.Text] = Convert.ToDecimal(textBoxFuelPricePerL.Text);
        }
    }
}
