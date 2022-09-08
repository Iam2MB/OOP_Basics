using System;
using System.Collections.Generic;

namespace DZ_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Кучма Андрей Витальевич & Kuchma@mail.ru";

            Console.WriteLine(data);

            SearchMail(ref data);

            Console.WriteLine(data);

        }

        public static void SearchMail(ref string data)
        {
            string[] words = data.Split(new char[] { '&' });

            data = words[1].Remove(0, 1);

            Console.WriteLine(data);
        }
    }
}
