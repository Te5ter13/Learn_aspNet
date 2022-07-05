using System;
using static System.Console;
namespace numbers_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Sum of Two Numbers ");
            Write("Enter first Number ");
            int a = Convert.ToInt32(ReadLine());
            Write("Enter second Number ");
            int b = Convert.ToInt32(ReadLine());
            int sum = a + b;
            WriteLine($"Sum is {sum}");
        }
    }
}
