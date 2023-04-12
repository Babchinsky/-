using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4_hw_11._04._2023_Forms
{
    public partial class CafeForm : Form
    {
        MainForm parentForm;
        Dictionary<string, decimal> cafePrices;

        decimal totalPriceHotDog = 0;
        decimal totalPriceBurger = 0;
        decimal totalPriceFry = 0;
        decimal totalPriceCola = 0;

        public CafeForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
           
            textBoxPriceHotDog.Text = parentForm.prices.cafePrices[checkBox1.Text].ToString();
            textBoxPriceBurger.Text = parentForm.prices.cafePrices[checkBox2.Text].ToString();
            textBoxPriceFry.Text = parentForm.prices.cafePrices[checkBox3.Text].ToString();
            textBoxPriceCola.Text = parentForm.prices.cafePrices[checkBox4.Text].ToString();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPayableToCafe.Text = "0";
            textBoxCountHotDog.Text = "0";
            textBoxCountBurger.Text = "0";
            textBoxCountFry.Text = "0";
            textBoxCountCola.Text = "0";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPayableToCafe.Text))
                return;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            // сохраняем текст в файл
            string textToSave = String.Format($"{checkBox1.Text}: {textBoxPriceHotDog.Text} x {textBoxCountHotDog.Text} = {totalPriceHotDog}\n");
            textToSave += String.Format($"{checkBox2.Text}: {textBoxPriceBurger.Text} x {textBoxCountBurger.Text} = {totalPriceBurger}\n");
            textToSave += String.Format($"{checkBox3.Text}: {textBoxPriceFry.Text} x {textBoxCountFry.Text} = {totalPriceFry}\n");
            textToSave += String.Format($"{checkBox4.Text}: {textBoxPriceCola.Text} x {textBoxCountCola.Text} = {totalPriceCola}\n");
            textToSave += String.Format($"Total: {totalPriceHotDog + totalPriceCola + totalPriceBurger + totalPriceFry}\n\n");
            System.IO.File.AppendAllText(filename, textToSave);

            MessageBox.Show("Файл успешно сохранён!");
            //MessageBox.Show(textToSave);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                this.textBoxCountHotDog.Enabled = true;
            else
                this.textBoxCountHotDog.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                this.textBoxCountBurger.Enabled = true;
            else
                this.textBoxCountBurger.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                this.textBoxCountFry.Enabled = true;
            else
                this.textBoxCountFry.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                this.textBoxCountCola.Enabled = true;
            else
                this.textBoxCountCola.Enabled = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
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
        }
    }
}
