using System;
using System.Collections;
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
        public Dictionary<string, decimal> fuelPrices;
        public Form1()
        {
            InitializeComponent();

            CafePrice cafePrice = new CafePrice(85, 105, 95, 60);
            this.textBoxPriceHotDog.Text = cafePrice.PriceHotDog.ToString();
            this.textBoxPriceBurger.Text = cafePrice.PriceBurger.ToString();
            this.textBoxPriceFry.Text = cafePrice.PriceFry.ToString();
            this.textBoxPriceCola.Text = cafePrice.PriceCola.ToString();


            fuelPrices = new Dictionary<string, decimal>();
            fuelPrices.Add("A95 Plus", 49);
            fuelPrices.Add("А95", 47);
            fuelPrices.Add("А92", 46);
            fuelPrices.Add("Дизель", 22);
            fuelPrices.Add("Газ", 48);

            foreach (var item in fuelPrices)
            {
                this.comboBox1.Items.Add(item.Key);
            }
            this.comboBox1.SelectedIndex = 0;

            textBoxFuelPricePerL.Text = fuelPrices[this.comboBox1.Text].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                this.textBoxCountHotDog.Enabled = true;
            else 
                this.textBoxCountHotDog.Enabled = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) 
                this.textBoxCountBurger.Enabled = true;
            else 
                this.textBoxCountBurger.Enabled = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) 
                this.textBoxCountFry.Enabled = true;
            else 
                this.textBoxCountFry.Enabled = false;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) 
                this.textBoxCountCola.Enabled = true;
            else 
                this.textBoxCountCola.Enabled = false;
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
                textBoxFuelCount.Enabled = true;
                textBoxGasMoney.Enabled = false;
            }
            else
            {
                textBoxFuelCount.Enabled = false;
                textBoxGasMoney.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Cafe
            decimal totalPriceHotDog = 0;
            decimal totalPriceBurger = 0;
            decimal totalPriceFry = 0;
            decimal totalPriceCola = 0;


            if (checkBox1.Checked == true && textBoxCountHotDog.Text != "")
                totalPriceHotDog = Convert.ToDecimal(textBoxPriceHotDog.Text) * Convert.ToDecimal(textBoxCountHotDog.Text);
            else totalPriceHotDog = 0;

            if (checkBox2.Checked == true && textBoxCountBurger.Text != "")
                totalPriceBurger = Convert.ToDecimal(textBoxPriceBurger.Text) * Convert.ToDecimal(textBoxCountBurger.Text);
            else totalPriceBurger = 0;

            if (checkBox3.Checked == true && textBoxCountFry.Text != "")
                totalPriceFry = Convert.ToDecimal(textBoxPriceFry.Text) * Convert.ToDecimal(textBoxCountFry.Text);
            else totalPriceFry = 0;

            if (checkBox4.Checked == true && textBoxCountCola.Text != "")
                totalPriceCola = Convert.ToDecimal(textBoxPriceCola.Text) * Convert.ToDecimal(textBoxCountCola.Text);
            else totalPriceCola = 0;

            decimal totalPriceCafe = totalPriceHotDog + totalPriceCola + totalPriceBurger + totalPriceFry;

            textBoxPayableToCafe.Text = totalPriceCafe.ToString();
            #endregion

            #region FuelStation

            decimal totalPriceGas = 0;


            if (radioButton1.Checked == true && textBoxFuelCount.Text != "")
            {
                totalPriceGas = Convert.ToDecimal(textBoxFuelPricePerL.Text) * Convert.ToDecimal(textBoxFuelCount.Text);
            }

            if (radioButton2.Checked == true && textBoxGasMoney.Text != "")
            {
                totalPriceGas = Convert.ToDecimal(textBoxGasMoney.Text);
                textBoxFuelCount.Text = (totalPriceGas / Convert.ToDecimal(textBoxFuelPricePerL.Text)).ToString();
            }

            textBoxGasMoney.Text = totalPriceGas.ToString();
            textBoxPayableToGas.Text = totalPriceGas.ToString();

            #endregion


            decimal totalPrice = totalPriceCafe + totalPriceGas;
            textBoxPayableToTotal.Text = totalPrice.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFuelPricePerL.Text = fuelPrices[this.comboBox1.Text].ToString();
        }
    }
}
