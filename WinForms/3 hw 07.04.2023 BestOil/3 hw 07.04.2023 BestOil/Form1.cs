using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_hw_07._04._2023_BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CafePrice cafePrice = new CafePrice(85, 105, 95, 60);

            this.textBoxPriceHotDog.Text = cafePrice.PriceHotDog.ToString();
            this.textBoxPriceBurger.Text = cafePrice.PriceBurger.ToString();
            this.textBoxPriceFry.Text = cafePrice.PriceFry.ToString();
            this.textBoxPriceCola.Text = cafePrice.PriceCola.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) this.textBoxCountHotDog.Enabled = true;
            else this.textBoxCountHotDog.Enabled = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) this.textBoxCountBurger.Enabled = true;
            else this.textBoxCountBurger.Enabled = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) this.textBoxCountFry.Enabled = true;
            else this.textBoxCountFry.Enabled = false;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) this.textBoxCountCola.Enabled = true;
            else this.textBoxCountCola.Enabled = false;
        }

        // Для того, чтобы можно было вводить только цифры
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxGasCount.Enabled = true;
                textBoxGasMoney.Enabled = false;
            }
            else
            {
                textBoxGasCount.Enabled = false;
                textBoxGasMoney.Enabled = true;
            }
        }
    }
}
