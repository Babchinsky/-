using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WhoWantToBeMillioner
{
    public partial class Form1 : Form
    {

        int maxQuestions = 15;
        public List<string> questions;
        public List<Tuple<string, string, string, string>> Answers;

        public  List<string> RightAnswers;
        Form2 add;
        int Current = 0;
        int seconds = 0;


        public Form1()
        {
            InitializeComponent();
            // включаем двойную буферизацию для элемента ListBox
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += listBox1_DrawItem;

        

            questions = new List<string>
                {
                    "Какое животное является символом России?",
                    "Как называется главный орган дыхания у человека?",
                    "Кто из этих ученых изобрел телефон?",
                    "Какой город является столицей Франции?",
                    "Какой элемент используется для создания ядерной энергии?",
                    "Какой инструмент используется для измерения температуры?",
                    "Какое море находится между Европой и Азией?",
                    "Какой вид спорта включает в себя наклонное поле и ворота?",
                    "Как называется знаменитый театр оперы и балета в Москве?",
                    "Какой вид животных является самым большим на Земле?",
                    "Как называется самый длинный река в США?",
                    // Добавьте остальные вопросы здесь
                };

            Answers = new List<Tuple<string, string, string, string>>
                {
                    Tuple.Create("Медведь", "Тигр", "Лев", "Волк"),
                    Tuple.Create("Сердце", "Желудок", "Легкие", "Печень"),
                    Tuple.Create("Александр Флеминг", "Томас Эдисон", "Александр Грэм Белл", "Никола Тесла"),
                    Tuple.Create("Лондон", "Берлин", "Париж", "Рим"),
                    Tuple.Create("Углерод", "Железо", "Ртуть", "Уран"),
                    Tuple.Create("Термометр", "Барометр", "Гидрометр", "Амперметр"),
                    Tuple.Create("Черное море", "Каспийское море", "Средиземное море", "Мраморное море"),
                    Tuple.Create("Хоккей", "Горные лыжи", "Сноубординг", "Фигурное катание"),
                    Tuple.Create("Кремлевский театр", "Большой театр", "Мариинский театр", "Эрмитаж"),
                    Tuple.Create("Синий кит", "Слон", "Гепард", "Крокодил"),
                    Tuple.Create("Миссисипи", "Миссури", "Нил", "Амазонка"),
                    // Добавьте остальные ответы здесь
                };

            RightAnswers = new List<string>
                {
                    "Медведь",
                    "Легкие",
                    "Александр Грэм Белл",
                    "Париж",
                    "Уран",


                    "Термометр",
                    "Черное море",
                    "Горные лыжи",
                    "Большой театр",
                    "Синий кит",
                    "Миссисипи",
                // Добавьте остальные правильные ответы здесь

            

          


        };

            questions.Add("Какой металл является самым распространенным в земной коре?");
            Answers.Add(Tuple.Create("Алюминий", "Железо", "Медь", "Свинец"));
            RightAnswers.Add("Железо");

            questions.Add("Какой город является столицей Японии?");
            Answers.Add(Tuple.Create("Киото", "Осака", "Токио", "Хоккайдо"));
            RightAnswers.Add("Токио");

            questions.Add("Какой химический элемент обозначается символом K?");
            Answers.Add(Tuple.Create("Кислород", "Кальций", "Калий", "Карбон"));
            RightAnswers.Add("Калий");

            questions.Add("Какой вид спорта предполагает наличие судей на ринге?");
            Answers.Add(Tuple.Create("Бокс", "Кикбоксинг", "Муай-тай", "Карате"));
            RightAnswers.Add("Бокс");

            
        }


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // определяем, является ли текущий элемент нечетным
            if (e.Index == 0 || e.Index == 5 || e.Index == 10)
            {
                // изменяем цвет фона элемента
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            }
            else if (e.Index == listBox1.SelectedIndex) {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            }
            else
            {

                e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
            }

            // рисуем текст элемента
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }
   
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Current = 0;

            
            foreach (Control item in this.Controls)
            {


                item.Enabled = true;

            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            
            Answer_A.BackColor = Color.Black;
            Answer_B.BackColor = Color.Black;
            Answer_C.BackColor = Color.Black;
            Answer_D.BackColor = Color.Black;


           
            NextQuestion();
        }



        private void Clear()
        {
            groupBox1.Visible = false;
            foreach (Control item in this.Controls)
            {
                
                if(item as MenuStrip != null)
                {

                }
                else
                {
                    item.Enabled = false;
                }
            }


         
        }
        private void NextQuestion()
        {
            
            Question.Text = questions[Current];

            Answer_A.Text = Answers[Current].Item1;
            Answer_B.Text = Answers[Current].Item2;
            Answer_C.Text = Answers[Current].Item3;
            Answer_D.Text = Answers[Current].Item4;
            Answer_A.Enabled = true;
            Answer_B.Enabled = true;
            Answer_C.Enabled = true;
            Answer_D.Enabled = true;
        }
        private void Answer_A_Click(object sender, EventArgs e)
        {
            if(Answer_A.Text == RightAnswers[Current])
            {
               
                pictureBox3.Visible = true;
                Correct.Visible= true;
                Current++;
                Answer_A.BackColor = Color.Green;
                timer1.Start();
              
              
                listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current];
            }
            else
            {
                Answer_A.BackColor = Color.Red;
                MessageBox.Show("You lose :-(");
                Clear();
            }
           pictureBox2.Visible = false;
           RightAnswer.Visible = false;
            groupBox1.Visible = false;
        }

        private void Answer_B_Click(object sender, EventArgs e)
        {
            if (Answer_B.Text == RightAnswers[Current])
            {

                pictureBox3.Visible = true;
                Correct.Visible = true;
                Current++;
                Answer_B.BackColor = Color.Green;
                timer1.Start();
                listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current];
            }
            else
            {
                Answer_B.BackColor = Color.Red;
                MessageBox.Show("You lose :-(");
                Clear();
            }
            pictureBox2.Visible = false;
            RightAnswer.Visible = false;
            groupBox1.Visible = false;
        }

        private void Answer_C_Click(object sender, EventArgs e)
        {
            if (Answer_C.Text == RightAnswers[Current])
            {

                pictureBox3.Visible = true;
                Correct.Visible = true;
                Answer_C.BackColor = Color.Green;
                Current++;
                timer1.Start();


                listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current];
            }
            else
            {
                Answer_C.BackColor = Color.Red;
                MessageBox.Show("You lose :-(");
                Clear();
            }
            pictureBox2.Visible = false;
            RightAnswer.Visible = false;
            groupBox1.Visible = false;
        }

        private void Answer_D_Click(object sender, EventArgs e)
        {
            if (Answer_D.Text == RightAnswers[Current])
            {

                pictureBox3.Visible = true;
                Correct.Visible = true;
                Current++;
                Answer_D.BackColor = Color.Green;
                timer1.Start();


                listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current];
                
            }
            else
            {
                Answer_D.BackColor = Color.Red;
                MessageBox.Show("You lose :-(");
                Clear();
            }
            pictureBox2.Visible = false;
            RightAnswer.Visible = false;

            groupBox1.Visible = false;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Invalidate(listBox1.GetItemRectangle(i));
            }
            if (listBox1.SelectedIndex == 0)
            {
                MessageBox.Show("You won");
                this.Close();
            }
           
            //listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current-1];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (seconds == 2)
            {
                NextQuestion();
                seconds = 0;
                pictureBox3.Visible = false;
                Correct.Visible = false;
                Answer_A.BackColor = Color.Black;
                Answer_B.BackColor = Color.Black;
                Answer_C.BackColor = Color.Black;
                Answer_D.BackColor = Color.Black;
                timer1.Stop();
            }
            seconds++;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - Current];

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 3);

            button1.Enabled = false;
            Answer_A.Enabled = false;
            Answer_B.Enabled = false;
            Answer_C.Enabled = false;
            Answer_D.Enabled = false;
            if (Answer_A.Text == RightAnswers[Current])
            {
                Answer_A.Enabled = true;
               
                switch (r)
                {
                    case 1: Answer_B.Enabled = true;break;
                    case 2: Answer_C.Enabled = true;break;
                    case 3: Answer_D.Enabled = true; break;
                    default:
                        break;
                }
            }
            else if(Answer_B.Text == RightAnswers[Current])
            {
                Answer_B.Enabled = true;
                switch (r)
                {
                    case 1: Answer_A.Enabled = true; break;
                    case 2: Answer_C.Enabled = true; break;
                    case 3: Answer_D.Enabled = true; break;
                    default:
                        break;
                }
            }
            else if (Answer_C.Text == RightAnswers[Current])
            {
                Answer_C.Enabled = true;
                switch (r)
                {
                    case 1: Answer_A.Enabled = true; break;
                    case 2: Answer_B.Enabled = true; break;
                    case 3: Answer_D.Enabled = true; break;
                    default:
                        break;
                }
            }
            else if (Answer_D.Text == RightAnswers[Current])
            {
                Answer_D.Enabled = true;
                switch (r)
                {
                    case 1: Answer_A.Enabled = true; break;
                    case 2: Answer_B.Enabled = true; break;
                    case 3: Answer_C.Enabled = true; break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            RightAnswer.Visible = true;
            RightAnswer.Text = RightAnswers[Current];
            button2.Enabled = false;





        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            groupBox1.Visible = true;


            Random random=new Random();

            int[] ABCD =new int[4];

            for (int i = 0; i < 4; i++)
            {
                ABCD[i] = random.Next(1, 100);
            }
            if (ABCD[0] > 50)
            {
                ABCD[1]=random.Next(1, ABCD[0]);
            }
            else
            {
                ABCD[1]=random.Next(ABCD[0], 100);
            }
            if (ABCD[1] > 50)
            {
                ABCD[2] = random.Next(1, ABCD[1]);
            }
            else
            {
                ABCD[2] = random.Next(ABCD[1], 100);
            }
            if (ABCD[2] > 50)
            {
                ABCD[3] = random.Next(1, ABCD[3]);
            }
            else
            {
                ABCD[3] = random.Next(ABCD[3], 100);
            }
           
       
           if(Answer_A.Text == RightAnswers[Current])
            {
                int temp = ABCD[0];
                int max = ABCD.Max();
                
                ABCD[ABCD.ToList().IndexOf(ABCD.Max())]=temp;

                ABCD[0] = max;

            }
            else if(Answer_B.Text == RightAnswers[Current])
            {
                int temp = ABCD[1];
                int max = ABCD.Max();

                ABCD[ABCD.ToList().IndexOf(ABCD.Max())] = temp;

                ABCD[1] = max;
            }
            else if (Answer_C.Text == RightAnswers[Current])
            {
                int temp = ABCD[2];
                int max = ABCD.Max();

                ABCD[ABCD.ToList().IndexOf(ABCD.Max())] = temp;

                ABCD[2] = max;
            }
            else if (Answer_D.Text == RightAnswers[Current])
            {
                int temp = ABCD[3];
                int max = ABCD.Max();

                ABCD[ABCD.ToList().IndexOf(ABCD.Max())] = temp;

                ABCD[3] = max;
            }

            label1.Text = $"A: {ABCD[0]}%";
            label2.Text = $"B: {ABCD[1]}%";
            label3.Text = $"C: {ABCD[2]}%";
            label4.Text = $"D: {ABCD[3]}%";

            progressBar1.Value = ABCD[0];
            progressBar2.Value = ABCD[1];
            progressBar3.Value = ABCD[2];
            progressBar4.Value = ABCD[3];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {

            maxQuestions--;
            if (maxQuestions < 15)
            {

                add = new Form2();

                add.ShowDialog();
                questions.Add(add.questions[0]);
                Answers.Add(add.Answers[0]);
                RightAnswers.Add(add.RightAnswer[0]);
                
            }
            else
            {
                MessageBox.Show("Max questions");
            }

        }
        Form3 form3;
        private void удToolStripMenuItem_Click(object sender, EventArgs e)
        {
           form3=new Form3();
            form3.ParentForm = this;
            form3.ShowDialog();
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(questions.Count().ToString());
        }
        Form4 form4;
        private void редактироватьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.ParentForm = this;
            form4.ShowDialog();

        }
    }
}
