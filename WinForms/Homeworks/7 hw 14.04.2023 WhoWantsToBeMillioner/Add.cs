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
    public partial class Form2 : Form
    {

       public List<string> questions { get; set; }
        public List<Tuple<string, string, string, string>> Answers { get; set; }
        public List<string> RightAnswer
        {
            get; set;
        }
        public Form2()
        {
            InitializeComponent();
            Answers = new List<Tuple<string, string, string, string>>();
            questions=new List<string>();
            RightAnswer=new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != ""&& textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                questions.Add(textBox1.Text);
                Answers.Add(new Tuple<string,string,string,string>(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text));
                RightAnswer.Add(textBox2.Text);
                this.Close();
            }
        }
    }
}
