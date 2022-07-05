using System;
using static System.Console;
namespace sealed_demo
{
    //Sealed identifier is used for sealed class
    sealed class sealedDemo{
        public void add(int x , int y){
            WriteLine("Sum is "+(x+y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sealedDemo obj = new sealedDemo();
            obj.add(10, 15);
        }
    }
}
