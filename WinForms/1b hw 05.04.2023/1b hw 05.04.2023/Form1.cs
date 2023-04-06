using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1b_hw_05._04._2023
{
    public partial class Form1 : Form
    {
        Keys keys;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keys = e.KeyCode;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form parentForm = (Form)sender;

            #region LeftMouseButton

            if (e.Button == MouseButtons.Left)
            {
                if (keys == Keys.ControlKey) Application.Exit();
  

                if (e.X > 10 && e.X < this.ClientSize.Width - 10 && e.Y > 10 && e.Y < this.ClientSize.Height - 10)
                    MessageBox.Show("Мышь находится внутри прямоугольника");   
                
                else if (e.X == 10 && e.X == this.ClientSize.Width - 10 && e.Y == 10 && e.Y == this.ClientSize.Height - 10)
                    MessageBox.Show("Мышь находится на границе прямоугольника");

                else MessageBox.Show("Мышь находится за пределами прямоугольника");
            }

            #endregion

            #region RightMouseButton 
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(String.Format("Width = {0}  Height = {1}", this.Size.Width, this.Size.Height));
            }
            #endregion
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form parentForm = (Form)sender;
            parentForm.Text = String.Format("x = {0}  y = {1}  Button = {2}", e.X, e.Y, e.Button);
        }
    }
}
