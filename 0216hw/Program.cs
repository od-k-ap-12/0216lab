using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216hw
{
    struct Fraction
    {
        public int numerator { get; set; }
        public int denominator;
        public Fraction(int _numerator,int _denominator)
        {
            numerator = _numerator;
            denominator = _denominator;

        }
        public int propDenominator
        {
            get => numerator;
            set
            {
                if (denominator != 0)
                {
                    denominator = value;
                }
                else
                {
                    throw new Exception("Denominator can't be 0");
                }
            }
        }
        public void Print()
        {
            Console.WriteLine(numerator / denominator);
        }
        public int Plus(Fraction f2)
        {
            return (this.numerator / this.denominator) + (f2.numerator / f2.denominator);
        }
        public int Minus(Fraction f2)
        {
            return (this.numerator / this.denominator) - (f2.numerator / f2.denominator);
        }
        public int Multiply(Fraction f2)
        {
            return (this.numerator / this.denominator) / (f2.numerator / f2.denominator);
        }
        public int Divide(Fraction f2)
        {
            return (this.numerator / this.denominator) * (f2.numerator / f2.denominator);
        }
    }
    struct ComplexNumber
    {
        public int real { get; set; }
        public int imaginary{ get; set; }
        public ComplexNumber(int _real,int _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }
        public void Print()
        {
            if (imaginary< 0)
            {
                Console.WriteLine(real + "-" + imaginary + "i");
            }
            else
            {
                Console.WriteLine(real + "+" + imaginary + "i");
            }
        }
        public string Plus(ComplexNumber cn2)
        {
            double realresult = this.real + cn2.real;
            double imaginaryresult = this.imaginary + cn2.imaginary;
            if (imaginaryresult < 0)
            {
                return realresult+"-"+imaginaryresult+"i";
            }
            else
            {
                return realresult + "+" + imaginaryresult + "i";
            }
        }
        public string Minus(ComplexNumber cn2)
        {
            double realresult = this.real - cn2.real;
            double imaginaryresult = this.imaginary - cn2.imaginary;
            if (imaginaryresult < 0)
            {
                return realresult + "-" + imaginaryresult + "i";
            }
            else
            {
                return  realresult + "+" + imaginaryresult + "i";
            }
        }
        public string Multiply(ComplexNumber cn2)
        {
            double realresult = (this.real * cn2.real) - (this.imaginary*cn2.imaginary);
            double imaginaryresult = (this.real * cn2.imaginary) + (this.imaginary*cn2.real);
            if (imaginaryresult < 0)
            {
                return realresult + "-" + imaginaryresult + "i";
            }
            else
            {
                return realresult + "+" + imaginaryresult + "i";
            }
        }
        public string Divide(ComplexNumber cn2)
        {
            double realresult = ((this.real * cn2.real) + (this.imaginary*cn2.imaginary))/(Math.Pow(cn2.real,2)+Math.Pow(cn2.imaginary,2));
            double imaginaryresult = ((cn2.real * this.imaginary) - (this.real * cn2.imaginary)) / (Math.Pow(cn2.real, 2) + Math.Pow(cn2.imaginary, 2));
            if (imaginaryresult < 0)
            {
                return realresult + "-" + imaginaryresult + "i";
            }
            else
            {
                return realresult + "+" + imaginaryresult + "i";
            }
        }
    }
    struct Birthday
    {
        public DateTime _Birthday { get; set; }
        public Birthday(int day,int month,int year)
        {
            _Birthday = new DateTime(year, month, day, 0, 0, 0);
        }
        public void Print()
        {
            Console.WriteLine(_Birthday);
        }
        public void Input(int day,int month,int year)
        {
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            _Birthday = new DateTime(year, month, day, 0, 0, 0);

        }
        public System.DayOfWeek CustomYearDayOfWeek(int year)
        {
            DateTime CustomBirthday = new DateTime(year, _Birthday.Month, _Birthday.Day, 0, 0, 0);
             return CustomBirthday.DayOfWeek;
        }
        public System.DayOfWeek BirthdayYearDayOfWeek()
        {
            return _Birthday.DayOfWeek;
        }
        public double DaysLeft()
        {
            DateTime today = DateTime.Today;
            DateTime birth = new DateTime(today.Year, _Birthday.Month, _Birthday.Day);
            return (birth - today).TotalDays;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region test 1
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(2, 1);
            Console.WriteLine("Plus: "+f1.Plus(f2));
            Console.WriteLine("Minus: " + f1.Minus(f2));
            Console.WriteLine("Multiply: " + f1.Multiply(f2));
            Console.WriteLine("Divide: " + f1.Divide(f2));
            #endregion

            #region test 2
            ComplexNumber cn1 = new ComplexNumber(2, 3);
            ComplexNumber cn2 = new ComplexNumber(2, 1);
            Console.WriteLine("Plus: " + cn1.Plus(cn2));
            Console.WriteLine("Minus: " + cn1.Minus(cn2));
            Console.WriteLine("Multiply: " + cn1.Multiply(cn2));
            Console.WriteLine("Divide: " + cn1.Divide(cn2));

            #endregion

            #region test 3
            Birthday bd = new Birthday(07, 10, 2003);
            bd.Print();
            Console.WriteLine(bd.CustomYearDayOfWeek(2024));
            Console.WriteLine(bd.BirthdayYearDayOfWeek());
            Console.WriteLine(bd.DaysLeft());


            #endregion
        }
    }
}
