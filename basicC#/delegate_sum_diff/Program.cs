using System;
using static System.Console;

namespace delegate_sum_diff
{
    public delegate void myDelegate(int a , int b);

    class Program
    {
        public void Sum(int x , int y){
            WriteLine("Sum is "+ (x + y));
        }
        public void Diff(int x , int y){
            WriteLine("Difference is "+(x-y));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            myDelegate sum_diff = new myDelegate(obj.Sum);
            sum_diff += new myDelegate(obj.Diff);
            WriteLine("Enter Two numbers\n");
            Write("Enter first Number ");
            int a = Convert.ToInt32(ReadLine());
            Write("\nEnter second Number ");
            int b = Convert.ToInt32(ReadLine());
            sum_diff(a , b);
        }
    }
}
