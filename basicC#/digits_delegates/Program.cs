using System;
using static System.Console;
namespace digits_delegates
{
    // Program to Reverse and Sum the given digits using Delegate 
    public delegate void sumDelegates(int n);
    class Program
    {
        public void reverseDigits(int digits_number){
            int rev = 0;
            int sum = 0;
            while (digits_number > 0)
            {
                int i = digits_number % 10;
                rev = rev * 10 + i;
                sum = i + sum;
                digits_number= digits_number / 10;

            }
            WriteLine("Reverse Digit is "+rev);
            WriteLine("Sum is "+sum);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            sumDelegates digits = obj.reverseDigits;
            WriteLine("Enter a number");
            int num = Convert.ToInt32(ReadLine());
            digits.Invoke(num);
            
        }
    }
}
