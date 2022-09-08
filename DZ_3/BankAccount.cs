using System;

namespace DZ_3
{
    enum TypeOfAccount
    {
        DEBIT = 1,
        CREDIT = 2,
        DEPOSIT = 3
    }

    class BankAccount
    {
        string Login { get; set; }
        string NumberAccount { get; set; }
        double Balance { get; set; }
        TypeOfAccount TypeOfAccount { get; set; }

        /// <summary>
        /// Установить логин клиента
        /// </summary>
        /// <param name="name"></param>
        public void SetLogin(string name)
        {
            Login = name;
        }

        /// <summary>
        /// Установить тип счета. Выберите один из вариантов: 1 - Дебит, 2 - Кредит, 3 - Депозит
        /// </summary>
        /// <param name="type"></param>
        public void SetTypeOfAccount(int type)
        {
            if (0 < type && type < 4) 
            {
                TypeOfAccount = (TypeOfAccount)type;
            }
            else
            {
                Console.WriteLine("Введен неправильный номер типа");
                Console.WriteLine("Выберите один из вариантов:\n 1 - Дебит\n 2 - Кредит\n 3 - Депозит");
            }
            
        }

        /// <summary>
        /// Установить баланс
        /// </summary>
        /// <param name="num"></param>
        public void SetBalance(double num)
        {
            Balance = num;
        }

        /// <summary>
        /// Положить на баланс
        /// </summary>
        /// <param name="num"></param>
        public void UpBalance(double num)
        {
            Balance += num;
        }

        /// <summary>
        /// Снять с баланса
        /// </summary>
        /// <param name="num"></param>
        public void DownBalance(double num)
        {
            if (Balance - num > 0)
            {
                Balance -= num;
            }
            else 
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        /// <summary>
        /// Показать номер счета
        /// </summary>
        /// <returns></returns>
        public string InfoNumberAccount()
        {
            return NumberAccount;
        }

        /// <summary>
        /// Показать баланс
        /// </summary>
        /// <returns></returns>
        public double InfoBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Показать тип счета
        /// </summary>
        /// <returns></returns>
        public TypeOfAccount InfoTypeofAccount()
        {
            return TypeOfAccount;
        }

        /// <summary>
        /// Показать полную информацию о счете
        /// </summary>
        public void PrintAccountInfo()
        {
            Console.WriteLine("───");
            Console.WriteLine("Login:\t" + Login);
            Console.WriteLine("TypeOfAccount:\t" + TypeOfAccount);
            Console.WriteLine("NumberAccount:\t" + NumberAccount);
            Console.WriteLine("Balance:\t" + Balance.ToString());
            Console.WriteLine("───\n");
        }

        /// <summary>
        /// Генерация номера счета
        /// </summary>
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

        public void Transaction(BankAccount account, double amount)
        {
            account.DownBalance(amount);
            UpBalance(amount);
        }


        public BankAccount()
        {
            CreateNumberAccount();
            SetBalance(0);
        }

        public BankAccount(string login, int type)
        {
            SetLogin(login);
            SetTypeOfAccount(type);
            CreateNumberAccount();
            SetBalance(0);

        }

        public BankAccount(string login, int type, double balance)
        {
            SetLogin(login);
            SetTypeOfAccount(type);
            CreateNumberAccount();
            SetBalance(balance);

        }
    }
}
