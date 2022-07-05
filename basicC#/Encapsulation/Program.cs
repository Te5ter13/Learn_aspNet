using System;

namespace Encapsulation
{
    class Account{
        private int accountBalance = 10000;
        public void SetBalance(int amount){ // Setter method
            if (amount < 0)
            {
                Console.WriteLine("You cannot pass negative value");
            }
            else
            {
                accountBalance = amount;
            }
        }
        public void GetBalance(){
            Console.WriteLine("Your account blc is "+accountBalance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.SetBalance(-100);
            obj.GetBalance();
        }
    }
}
