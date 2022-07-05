using System;
using static System.Console;

namespace palindrome_check
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Checking The number is Palindrome or Not");
            Write("Enter a Number ");
            int number = Convert.ToInt32(ReadLine());
            int r, sum = 0;
            int temp = number;
            while (number > 0){
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if (temp == sum){
                WriteLine("Palindrome");
            }
            else{
                WriteLine("Not Palindrome");
            }
        }
    }
}
