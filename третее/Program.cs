using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace третее
{
    internal class BankAccount
    {
        public string owner;
        public double balance;
        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    owner = value;
                }
            }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public BankAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }
        public void Deposit(double sum)
        {
            if (sum < 0)
            {
                Console.WriteLine("нельзя так сделать");
            }
            else
            {
                Balance += sum;
                Console.WriteLine($"{owner}, баланс: {balance}");
            }
        }
        public void Withdraw(double sum)
        {
            if (sum < 0 && sum > balance)
            {
                Console.WriteLine("недостаточно средств");
            }
            else
            {
                Balance -= sum;
                Console.WriteLine($"{owner}, баланс: {balance}");
            }
        }
static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Матвей", 888);
            bankAccount.Deposit(1000);
            bankAccount.Withdraw(500);
            bankAccount.Withdraw(20000);
        }
    }
}
