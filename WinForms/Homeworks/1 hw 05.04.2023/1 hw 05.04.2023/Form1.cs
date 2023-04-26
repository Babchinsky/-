using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_hw_05._04._2023
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            ////////////////////////////////////////////////////////// Task 1
            //string text = "C++";
            //int textSize = 0;
            //DialogResult dr = MessageBox.Show(text, "Резюме 1");
            //textSize += text.Length;

            //text = "C#";
            //dr = MessageBox.Show(text, "Резюме 2");
            //textSize += text.Length;

            //text = "WindowsForms";
            //dr = MessageBox.Show(text, "Резюме 3");
            //textSize += text.Length;

            //dr = MessageBox.Show(textSize.ToString(), "Символов в резюме");
            ///////////////////////////////////////////////////////////////////

            string title = "Угадываю число";
            string text = "Ваше число ";
            int attemps;
            int number;
            Random random;
            DialogResult dr;

            do
            {
                attemps = 1;
                for (; ; attemps++)
                {
                    random = new Random();

                    number = random.Next(10);

                    dr = MessageBox.Show(text + number + '?', title, MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes) break;
                    else MessageBox.Show("Сейчас попробую ещё раз");
                }

                dr = MessageBox.Show($"Ура, я угадал с {attemps} попытки. Хотите сыграть ещё раз?", title, MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return;
            } while (true);
        }
    }
}
