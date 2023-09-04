using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _4_hw_11._04._2023_Forms
{
    public partial class GasStationForm : Form
    {
        MainForm parentForm;
        public GasStationForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;

            foreach (var item in parent.prices.fuelPrices)
            {
                this.comboBox1.Items.Add(item.Key);
            }
            this.comboBox1.SelectedIndex = 0;

            textBoxFuelPricePerL.Text = parentForm.prices.fuelPrices[this.comboBox1.Text].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFuelPricePerL.Text = parentForm.prices.fuelPrices[this.comboBox1.Text].ToString();

            decimal totalPriceGas = 0;


            if (radioButton1.Checked == true && textBoxFuelCount.Text != "")
                totalPriceGas = Convert.ToDecimal(textBoxFuelPricePerL.Text) * Convert.ToDecimal(textBoxFuelCount.Text);


            if (radioButton2.Checked == true && textBoxGasMoney.Text != "")
            {
                totalPriceGas = Convert.ToDecimal(textBoxGasMoney.Text);
                textBoxFuelCount.Text = (totalPriceGas / Convert.ToDecimal(textBoxFuelPricePerL.Text)).ToString();
            }

            textBoxGasMoney.Text = totalPriceGas.ToString();
            textBoxPayableToGas.Text = totalPriceGas.ToString();
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void textBoxFuelCount_TextChanged(object sender, EventArgs e)
        {
            decimal totalPriceGas = 0;


            if (radioButton1.Checked == true && textBoxFuelCount.Text != "")
                totalPriceGas = Convert.ToDecimal(textBoxFuelPricePerL.Text) * Convert.ToDecimal(textBoxFuelCount.Text);
            

            if (radioButton2.Checked == true && textBoxGasMoney.Text != "")
            {
                totalPriceGas = Convert.ToDecimal(textBoxGasMoney.Text);
                textBoxFuelCount.Text = (totalPriceGas / Convert.ToDecimal(textBoxFuelPricePerL.Text)).ToString();
            }

            textBoxGasMoney.Text = totalPriceGas.ToString();
            textBoxPayableToGas.Text = totalPriceGas.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFuelCount.Text))
                return;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            // сохраняем текст в файл
            string textToSave = String.Format($"{comboBox1.Text} x {textBoxFuelCount.Text} = {textBoxPayableToGas.Text}\n");
            System.IO.File.AppendAllText(filename, textToSave);

            MessageBox.Show("Файл успешно сохранён!");
            //MessageBox.Show(textToSave);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBoxFuelPricePerL.Text = parentForm.prices.fuelPrices[this.comboBox1.Text].ToString();
            textBoxFuelCount.Text = "";
            textBoxGasMoney.Text = "";

            textBoxPayableToGas.Text = "0";
        }
    }
}
