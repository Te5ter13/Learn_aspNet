using System;
using static System.Console;

namespace method_Overloading
{
    class Program
    {
        void Sum(int a, int b){
            WriteLine(a+b);
        }
        void Sum(float a, float b){
            WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(10,20);
        }
    }
}
