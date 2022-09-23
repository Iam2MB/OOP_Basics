using System;

namespace DZ_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение для шифрования: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            ACoder aCoder = new ACoder(text);
            Console.WriteLine($"ACoder шифрование");
            Console.WriteLine($"Encode:\t{aCoder.Encode()}");
            Console.WriteLine($"Decode:\t{aCoder.Decode()}");

            Console.WriteLine();

            BCoder bCoder = new BCoder(text);
            Console.WriteLine($"BCoder шифрование");
            Console.WriteLine($"Encode:\t{bCoder.Encode()}");
            Console.WriteLine($"Decode:\t{bCoder.Decode()}");

            Console.ReadKey();
        }
    }
}
