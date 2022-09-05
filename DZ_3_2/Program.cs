using System;
using static System.Net.Mime.MediaTypeNames;

namespace DZ_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Reverse(Console.ReadLine());

            Console.WriteLine(text);
        }

        static string Reverse(string text)
        {
            char[] reverse = text.ToCharArray();
            Array.Reverse(reverse);
            text = new string(reverse);

            return text;
        }
    }
}
