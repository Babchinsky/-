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

namespace _3_lab
{
    public partial class Form1 : Form
    {
        Process calcProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("word");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (calcProcess != null && !calcProcess.HasExited)
            //{
            //    // Закрытие окна калькулятора
            //    //calcProcess.CloseMainWindow();
            //    //calcProcess.WaitForExit();

            //    //// Завершение процесса RuntimeBroker.exe
            //    //Process[] processes = Process.GetProcessesByName("RuntimeBroker");
            //    //foreach (Process process in processes)
            //    //{
            //    //    process.Kill();
            //    //}

            //    //// Освобождение ресурсов, связанных с процессом калькулятора
            //    //calcProcess.Dispose();

            //    calcProcess.CloseMainWindow();
            //    calcProcess.WaitForExit();
            //    calcProcess.Dispose();
            //}
            foreach (var process in Process.GetProcessesByName("word"))
            {
                process.Kill();
            }
        }
    }
}
