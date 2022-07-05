using System;

namespace with_delegate_eg
{
    //First declare a delegate 
    public delegate void delegateSum(int x , int y);
    public delegate string delegateName(string Name);
    class Program
    {
        public void sum(int x , int y){
            Console.WriteLine(x+y);
        }
        public static string yourName(string name){
            return "Hello "+name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            delegateSum sum = new delegateSum(obj.sum);
            sum.Invoke(10,20);
            delegateName name = new delegateName(Program.yourName);
            string str = name("Raju");
            Console.WriteLine(str);
        }
    }
}
