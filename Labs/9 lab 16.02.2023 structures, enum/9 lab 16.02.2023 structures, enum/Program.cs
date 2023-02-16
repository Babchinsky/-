using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_lab_16._02._2023_structures__enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            Task_3();
        }

        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\tTask 1\n");
            Fraction f1 = new Fraction(2, 4);
            Fraction f2 = new Fraction(3, 12);
            Fraction f3 = f1 + f2;
            Console.WriteLine(f3);
        }
        struct Fraction
        {
            int numerator;
            int denominator;

            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public Fraction(Fraction fraction) : this(fraction.numerator, fraction.denominator) { }
            public static Fraction operator +(Fraction lhs, Fraction rhs)
            {
                Fraction result = new Fraction(lhs);
                result.numerator += rhs.numerator;
                result.denominator += rhs.denominator;

                return result;
            }

            public static Fraction operator -(Fraction lhs, Fraction rhs)
            {
                Fraction result = new Fraction(lhs);
                result.numerator -= rhs.numerator;
                result.denominator -= rhs.denominator;

                return result;
            }

            public static Fraction operator *(Fraction lhs, Fraction rhs)
            {
                Fraction result = new Fraction(lhs);
                result.numerator *= rhs.numerator;
                result.denominator *= rhs.denominator;

                return result;
            }

            public static Fraction operator /(Fraction lhs, Fraction rhs)
            {
                Fraction result = new Fraction(lhs);
                result.numerator /= rhs.numerator;
                result.denominator /= rhs.denominator;

                return result;
            }

            public override string ToString()
            {
                return $"Numerator: {numerator}\nDenominator: {denominator}";
            }
        }

        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\tTask 2\n");
            ComplexNum c1 = new ComplexNum(2, 4);
            ComplexNum c2 = new ComplexNum(3, 12);
            ComplexNum c3 = c1 + c2;
            Console.WriteLine(c3);
        }
        struct ComplexNum
        {
            int real;
            int imaginary;

            public ComplexNum(int real, int imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }
            public ComplexNum(ComplexNum ComplexNum) : this(ComplexNum.real, ComplexNum.imaginary) { }
            public static ComplexNum operator +(ComplexNum lhs, ComplexNum rhs)
            {
                ComplexNum result = new ComplexNum(lhs);
                result.real += rhs.real;
                result.imaginary += rhs.imaginary;

                return result;
            }

            public static ComplexNum operator -(ComplexNum lhs, ComplexNum rhs)
            {
                ComplexNum result = new ComplexNum(lhs);
                result.real -= rhs.real;
                result.imaginary -= rhs.imaginary;

                return result;
            }

            public static ComplexNum operator *(ComplexNum lhs, ComplexNum rhs)
            {
                ComplexNum result = new ComplexNum(lhs);
                result.real *= rhs.real;
                result.imaginary *= rhs.imaginary;

                return result;
            }

            public static ComplexNum operator /(ComplexNum lhs, ComplexNum rhs)
            {
                ComplexNum result = new ComplexNum(lhs);
                result.real /= rhs.real;
                result.imaginary /= rhs.imaginary;

                return result;
            }

            public override string ToString()
            {
                return $"real: {real}\nimaginary: {imaginary}";
            }
        }

        public static void Task_3()
        {
            Console.WriteLine("\n\n\t\tTask 3\n");
            Birthday b = new Birthday(new DateTime(2003, 07, 11));
            //b.Init();
            Console.WriteLine(b);
            b.Day_Of_Week();
            b.Day_Of_Week(2024);
            Console.WriteLine(b.DaysBeforeBithday());
        }

        struct Birthday
        {
            DateTime birthday;

            public Birthday(DateTime birthday)
            {
                this.birthday = birthday;
            }

            public void Init()
            {
                Console.Write("Enter the day of your birthday (11.07.2003): ");
                birthday = Convert.ToDateTime(Console.ReadLine());
            }

            public void Day_Of_Week()
            {
                Console.WriteLine(birthday.ToString("dddd"));
            }

            public void Day_Of_Week(int year)
            {
                DateTime buf = new DateTime(year, birthday.Month, birthday.Day);
                Console.WriteLine(buf.ToString("dddd"));
            }

            public int DaysBeforeBithday()
            {
                DateTime now = DateTime.Now;
                DateTime nextBirthday = new DateTime(now.Year, birthday.Month, birthday.Day);

                if (now.Month > birthday.Month) nextBirthday.AddYears(1);
                else if (birthday.Month == now.Month && now.Day > birthday.Day) nextBirthday.AddYears(1);

                return (int)(nextBirthday - now).TotalDays;
            }

            public override string ToString()
            {
                return birthday.ToString("dd MMMM, yyyy");
            }
        }
    }
}
