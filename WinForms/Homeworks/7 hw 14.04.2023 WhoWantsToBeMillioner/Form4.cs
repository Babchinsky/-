using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantToBeMillioner
{
    public partial class Form4 : Form
    {

       public Form1 ParentForm { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = ParentForm.questions[Convert.ToInt32(numericUpDown1.Value)];

            textBox3.Text = ParentForm.Answers[Convert.ToInt32(numericUpDown1.Value)].Item1;
            textBox4.Text = ParentForm.Answers[Convert.ToInt32(numericUpDown1.Value)].Item2;
            textBox5.Text = ParentForm.Answers[Convert.ToInt32(numericUpDown1.Value)].Item3;
            textBox6.Text = ParentForm.Answers[Convert.ToInt32(numericUpDown1.Value)].Item3;

            textBox6.Text=ParentForm.RightAnswers[Convert.ToInt32(numericUpDown1.Value)];




        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm.questions[Convert.ToInt32(numericUpDown1.Value)] = textBox1.Text;

            Tuple<string, string, string, string> tuple;
            tuple=Tuple.Create(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            ParentForm.Answers[Convert.ToInt32(numericUpDown1.Value)]=tuple;
            ParentForm.RightAnswers[Convert.ToInt32(numericUpDown1.Value)]=textBox2.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
