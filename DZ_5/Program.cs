using System;

namespace DZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(2, 9);
            Fraction fraction2 = new Fraction(3, 8);

            bool result = fraction1 == fraction2;
            Console.WriteLine(result);

            bool result2 = fraction1 < fraction2;
            Console.WriteLine(result2);

            Fraction result3 = fraction1 + fraction2;
            Console.WriteLine(result3.ToString());
        }
    }
}
