using System;
using static System.Console;

namespace without_delegate_eg
{
    class Program
    {
        public void sum(int x , int y){
            WriteLine(x+y);
        }
        public static string yourName(string Name){
            return "Hello "+Name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(10,20);
            string str = Program.yourName("Ram");
            WriteLine(str);

        }
    }
}
