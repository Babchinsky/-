using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_hw_20._04._2023_Process
{
    public partial class Form1 : Form
    {
        Process[] proc;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAllProcess()
        {
            proc = Process.GetProcesses();

            listView1.Items.Clear();
            foreach (Process p in proc)
            {
                ListViewItem item = new ListViewItem(p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                listView1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void buttonEndTask_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                proc[listView1.SelectedIndices[0]].Kill();
                GetAllProcess();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void newProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StartProcess second = new StartProcess())
            {
                if (second.ShowDialog() == DialogResult.OK)
                {
                    GetAllProcess();
                }
            }
        }
    }
}
