using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_5
{
    public class Fraction
    {
        int Numerator { get; set; }
        int Denominator { get; set; }

        public Fraction(int a, int b)
        {
            try
            {
                if (a > 0 && b == 0)
                {
                    throw new DivideByZeroException("В знаменателе не может быть нуля");
                }

                Numerator = a;
                Denominator = a == 0 ? a: b;
            }
            catch(DivideByZeroException error)
            {
                Console.WriteLine($"Ошибка: {error.Message}");
            }
        }

        public Fraction(int a)
        {
            Numerator = a;
            Denominator = a == 0 ? a : 1;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}",
                Numerator, Denominator);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(Fraction a, int b)
        {
            return a == new Fraction(b);
        }

        public static bool operator ==(int a, Fraction b)
        {

            return new Fraction(a) == b;
        }

        public static bool operator !=(Fraction a, int b)
        {
            return a != new Fraction(b);
        }

        public static bool operator !=(int a, Fraction b)
        {
            return new Fraction(a) != b;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.Numerator != b.Numerator) || (a.Denominator != b.Denominator);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fraction))
            {
                return false;
            }

            var number = (Fraction)obj;
            return Numerator == number.Numerator && Denominator == number.Denominator;
        }

        public override int GetHashCode()
        {
            return Numerator * Numerator + Denominator * Denominator;
        }

        //Возвращает наибольший общий делитель
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        //Возвращает сокращенную дробь
        public Fraction Reduce()
        {
            Fraction result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(Numerator, Denominator);
            result.Numerator /= greatestCommonDivisor;
            result.Denominator /= greatestCommonDivisor;
            return result;
        }

        private int CompareTo(Fraction that)
        {
            if (Equals(that))
            {
                return 0;
            }
            Fraction a = this.Reduce();
            Fraction b = that.Reduce();
            if (a.Numerator * b.Denominator > b.Numerator * a.Denominator)
            {
                return 1;
            }
            return -1;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator >(Fraction a, int b)
        {
            return a > new Fraction(b);
        }
        
        public static bool operator >(int a, Fraction b)
        {
            return new Fraction(a) > b;
        }
        
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.CompareTo(b) < 0;
        }
        
        public static bool operator <(Fraction a, int b)
        {
            return a < new Fraction(b);
        }
        
        public static bool operator <(int a, Fraction b)
        {
            return new Fraction(a) < b;
        }
        
        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.CompareTo(b) >= 0;
        }
        
        public static bool operator >=(Fraction a, int b)
        {
            return a >= new Fraction(b);
        }
        
        public static bool operator >=(int a, Fraction b)
        {
            return new Fraction(a) >= b;
        }
        
        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.CompareTo(b) <= 0;
        }
        
        public static bool operator <=(Fraction a, int b)
        {
            return a <= new Fraction(b);
        }
        
        public static bool operator <=(int a, Fraction b)
        {
            return new Fraction(a) <= b;
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction temp = new Fraction(a.Numerator * b.Denominator
                + b.Numerator * a.Denominator,
                a.Denominator * b.Denominator);

            while (true)
            {
                if (temp.Numerator % 10 == 0 && temp.Denominator % 10 == 0)
                {
                    temp.Numerator = temp.Numerator / 10;
                    temp.Denominator = temp.Denominator / 10;
                }
                else break;
            }
            return temp;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator
                - b.Numerator * a.Denominator,
                a.Denominator * b.Denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int a1 = a.Numerator * b.Numerator;
            int b1 = a.Denominator * b.Denominator;
            return new Fraction(a1, b1);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction temp = new Fraction(b.Denominator, b.Numerator);
            return a * temp;
        }

    }
}
