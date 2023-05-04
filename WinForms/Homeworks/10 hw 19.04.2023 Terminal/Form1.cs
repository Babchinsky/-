using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace terminal
{



    public partial class Form1 : Form
    {
   
      public List<Pessanger> pessanger { get; set; }
        public Form1()
        {
            InitializeComponent();
            pessanger=new List<Pessanger>();
        }

        private delegate void Pes(Pessanger p);

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ParentForm= this;
            form2.ShowDialog();


        }

            private void button1_Click(object sender, EventArgs e)
        {
            
                pessanger.Add(new Pessanger());
                listBox1.Items.Add(pessanger[pessanger.Count-1].GetInitals());

               
           
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text=(pessanger[pessanger.Count - 1].ToString());
        }
    }


   public class Pessanger
    {
        public string name { get; set; }
        public string initials { get; set; }

        int bag;
        int kg;
        public string RaceNumber;
        DateTime date;
        DateTime time;
        int hours;

        string destination;
        public Pessanger(Pessanger p)
        {
            this.name = p.name;
            this.initials = p.initials;
            this.bag = p.bag;
            this.kg = p.kg;
            this.date = p.date;
            this.time = p.time;
            this.hours = p.hours;
            this.RaceNumber = "0000";
            
        }
        public Pessanger()
        {
            name = "name";
            initials = "Initials";
            bag = 0;
            kg = 0;
            RaceNumber = "RaceNumb";

            date = new DateTime(12,12,12);
            time = new DateTime(12, 12, 12, 12, 12, 12);
            hours = 0;


        }

        public Pessanger(string name, string initials, int bag,int kg,DateTime date,DateTime time,int hours)
        {
            this.name = name;
            this.initials = initials;
            this.bag = bag;
            this.kg = kg;   
            this.date = date;
            this.time = time;
            this.hours = hours;
            this.RaceNumber = "0000";
        }
        public string GetInitals()
        {
            return $"{name} {initials}";
        }
        public override string ToString()
        {
            return $"{RaceNumber} bag :{bag} \n Date {date} \n time {time} \n hours {hours}";
        }

    }
}
