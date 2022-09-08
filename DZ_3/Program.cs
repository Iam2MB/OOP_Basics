using System;

namespace DZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Mr.X", 1, 125000);
            BankAccount account2 = new BankAccount("Ms.Y", 1, 56000);

            account1.PrintAccountInfo();
            account2.PrintAccountInfo();

            account2.Transaction(account1, 10200);

            account1.PrintAccountInfo();
            account2.PrintAccountInfo();

            Console.ReadKey(true);
        }
    }
}
