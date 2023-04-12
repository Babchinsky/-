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
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGasStation_Click(object sender, EventArgs e)
        {
            GasStationForm frm = new GasStationForm();
            DialogResult res = frm.ShowDialog();
            frm.Menu = this.Menu;
        }
    }
}
