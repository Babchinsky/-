using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class ForeignPassport: Passport
    {
        private string[] visas;
        public string Foreign_no { get; set; }

        public string this[int index]
        {
            get 
            {
                if (index >= 0 && index < visas.Length)
                {
                    return visas[index];
                }
                else throw new Exception("Некорректный индекс! " + index);
            }
            set 
            {
                if (index >= 0 && index < visas.Length)
                {
                    visas[index] = value;
                }
                else throw new Exception("Некорректный индекс! " + index);
            }
        }

        public ForeignPassport(string full_name, DateTime date_of_expiry, DateTime date_of_birth, string no, string[] visas, string foreign_no):base( full_name,  date_of_expiry,  date_of_birth,  no)
        {
            this.visas = visas;
            Foreign_no = foreign_no;
        }

        public override void Print()
        {
            base.Print();

            string str_visas = string.Join(", ", visas);

            Console.WriteLine($"Visas: {str_visas}\nForeign No.: {Foreign_no}\n");
        }

        public override string ToString()
        {

            string str_visas = string.Join(", ", visas);

            return base.ToString() + $"Visas: {str_visas}\nForeign No.: {Foreign_no}\n";
        }
    }
}
