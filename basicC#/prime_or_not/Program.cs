using System;
using static System.Console;
namespace prime_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Checking Whether Prime or not");
            Write("Enter a number ");
            int number = Convert.ToInt32(ReadLine());
            bool prime = true;
            int i;
            if (number == 0 || number == 1){
                prime = false;
            }
            else{
                for(i = 2; i <= (number/2); i++){
                if (number % i == 0){
                    prime = false;
                    }
                }

            }
            if (prime){
                WriteLine($"{number} is prime");
            }
            else{
                WriteLine($"{number} is not prime");
            }
        }
    }
}
