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
    public partial class MainForm : Form
    {
        public Prices prices;

        public MainForm()
        {
            InitializeComponent();
            prices = new Prices();

            prices.fuelPrices = new Dictionary<string, decimal>();
            prices.fuelPrices.Add("A95 Plus", 49);
            prices.fuelPrices.Add("А95", 47);
            prices.fuelPrices.Add("А92", 46);
            prices.fuelPrices.Add("Дизель", 22);
            prices.fuelPrices.Add("Газ", 48);

            prices.cafePrices = new Dictionary<string, decimal>();
            prices.cafePrices.Add("Хот-дог", 85);
            prices.cafePrices.Add("Бургер", 105);
            prices.cafePrices.Add("Фри", 95);
            prices.cafePrices.Add("Кола", 60);
        }

        private void buttonGasStation_Click(object sender, EventArgs e)
        {
            GasStationForm gasStationForm = new GasStationForm(this);
            DialogResult res = gasStationForm.ShowDialog();
        }

        private void buttonCafe_Click(object sender, EventArgs e)
        {
            CafeForm cafeForm = new CafeForm(this);
            DialogResult res = cafeForm.ShowDialog();
        }
    }
}
