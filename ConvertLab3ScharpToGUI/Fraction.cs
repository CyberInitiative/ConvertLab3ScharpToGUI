using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLab3ScharpToGUI
{
    public class Fraction
    {
        public int numerator;
        public int denominator;
        public Fraction() { numerator = denominator = 1; }
        public Fraction(int n, int d)
        {
            this.numerator = n;
            this.denominator = d;
        }

        public void ShowTheFractionMethod()
        {
            Console.WriteLine("Дробь в обыкновенном виде:" + "\n");
            Console.WriteLine("\0" + numerator);
            Console.WriteLine("\0" + "---");
            Console.WriteLine("\0" + denominator);
            Console.WriteLine("\n");
            Console.WriteLine("Дробь в десятичном виде:" + "\n");
            Console.WriteLine("\0" + Math.Round(((double)numerator / (double)denominator), 5));
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.numerator = (f1.numerator * f2.denominator + f1.denominator * f2.numerator);
            result.denominator = f1.denominator * f2.denominator;
            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.numerator = (f1.numerator * f2.denominator - f1.denominator * f2.numerator);
            result.denominator = f1.denominator * f2.denominator;
            return result;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.numerator = f1.numerator * f2.numerator;
            result.denominator = f1.denominator * f2.denominator;
            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction(1, 1);
            result.numerator = f1.numerator / f2.numerator;
            result.denominator = f1.denominator / f2.denominator;
            return result;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.denominator = f1.denominator * f2.denominator;
            result2.denominator = f1.denominator * f2.denominator;
            result1.numerator = (f1.numerator * f2.denominator);
            result2.numerator = (f1.denominator * f2.numerator);
            if (result1.numerator > result2.numerator)
                return true;
            else
                return false;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.denominator = f1.denominator * f2.denominator;
            result2.denominator = f1.denominator * f2.denominator;
            result1.numerator = (f1.numerator * f2.denominator);
            result2.numerator = (f1.denominator * f2.numerator);
            if (result1.numerator < result2.numerator)
                return true;
            else
                return false;
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.denominator = f1.denominator * f2.denominator;
            result2.denominator = f1.denominator * f2.denominator;
            result1.numerator = (f1.numerator * f2.denominator);
            result2.numerator = (f1.denominator * f2.numerator);
            if (result1.numerator == result2.numerator)
                return true;
            else
                return false;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            Fraction result1 = new Fraction();
            Fraction result2 = new Fraction();
            result1.denominator = f1.denominator * f2.denominator;
            result2.denominator = f1.denominator * f2.denominator;
            result1.numerator = (f1.numerator * f2.denominator);
            result2.numerator = (f1.denominator * f2.numerator);
            if (result1.numerator != result2.numerator)
                return true;
            else
                return false;
        }
    }
}