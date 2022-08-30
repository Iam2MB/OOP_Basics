using System;

namespace DZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account22 = new BankAccount("Mr.X", 1);
            account22.PrintAccountInfo();

        }
    }

    public enum TypeOfAccount
    {
        DEBIT = 1,
        CREDIT,
        DEPOSIT
    }

    class BankAccount
    {
        string Login { get; set; }
        string NumberAccount { get; set; }
        double Balance { get; set; }
        TypeOfAccount TypeOfAccount { get; set; }

        public void SetLogin(string name)
        {
            Login = name;
        }
        public void SetTypeOfAccount(int type)
        {
            TypeOfAccount = (TypeOfAccount)type;
        }
        public string InfoNumberAccount()
        {
            return NumberAccount;
        }
        public double InfoBalance()
        {
            return Balance;
        }
        public TypeOfAccount InfoTypeofAccount()
        {
            return TypeOfAccount;
        }
        void CreateNumberAccount()
        {
            int num = 0;
            Random random = new Random();

            string numberAccount = "";
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1000, 10000);

                numberAccount += num.ToString();
                if (i < 4)
                {
                    numberAccount += ' ';
                }
            }

            NumberAccount = numberAccount;
        }
        void CreateBalance()
        {
            Random random = new Random();

            Balance = Math.Round(random.Next(0, (int)Math.Pow(10, 9)) * 0.1, 2);
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine("───");
            Console.WriteLine("Login:\t" + Login);
            Console.WriteLine("TypeOfAccount:\t" + TypeOfAccount);
            Console.WriteLine("NumberAccount:\t" + NumberAccount);
            Console.WriteLine("Balance:\t" + Balance.ToString());
            Console.WriteLine("───\n");
        }

        public BankAccount(string login, int type)
        {
            SetLogin(login);
            SetTypeOfAccount(type);
            CreateNumberAccount();
            CreateBalance();

        }
    }
}
