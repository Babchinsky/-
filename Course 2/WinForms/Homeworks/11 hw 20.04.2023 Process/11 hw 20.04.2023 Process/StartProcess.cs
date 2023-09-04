using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _11_hw_20._04._2023_Process
{
    public partial class StartProcess : Form
    {
        public StartProcess()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOpen.Text))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = textBoxOpen.Text;
                proc.Start();
            }
        }
    }
}
