using System;
using static System.Console;
namespace array_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[10];
            int i;
            int sum = 0;
            WriteLine("Enter 10 numbers");
            for (i=0; i < 10; i++){
                number[i] = Convert.ToInt32(ReadLine());
            }
            Array.Sort(number);
            WriteLine("Arranging in ascending order");
            foreach (int nums in number)
            {
                Write(nums+", ");
            }
            int max = number[0];
            int min = number[0];
            foreach(int nums in number){
                sum = sum + nums;
                if (nums > max){
                    max = nums;
                }
                else
                {
                    min = nums;
                }
            }
            
            WriteLine("\nThe Max value is "+max);
            WriteLine("The Min number is "+min);
            WriteLine("Sum of array is "+sum);
        }
    }
}
