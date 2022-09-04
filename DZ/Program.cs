using System;

namespace DZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account22 = new BankAccount("Mr.X", 1, 100005);
            account22.UpBalance(500);
            account22.DownBalance(306);
            account22.SetTypeOfAccount(2);
            account22.PrintAccountInfo();
        }
    }
}
