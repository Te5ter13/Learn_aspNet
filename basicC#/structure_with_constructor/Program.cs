using System;
using static System.Console;
namespace structure_with_constructor
{
    struct SimpleInterest{
        public int principal;
        public double rate;
        public int time;


        //Parameterized Constructor
        public void getSI(int p, int t, double r){
            double si = (p*t*r)/100;
            WriteLine("Simple Interest is "+si);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
  
            SimpleInterest obj = new SimpleInterest();
            obj.principal = 100;
            obj.time = 2;
            obj.rate = 2.5;
            obj.getSI(obj.principal,obj.time,obj.rate); 
        }
    }
}
