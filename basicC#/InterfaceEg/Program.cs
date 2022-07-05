using System;

namespace InterfaceEg
{
    interface Iinterface1{
        void method1();
        void method2();
    }
    class Myclass1{
        public void M1(){
            Console.WriteLine("M1 from Class 1");
        }
    }
    class Myclass2:Myclass1,Iinterface1{
        public void method1(){
            Console.WriteLine("Method 1");
        }
        public void method2(){
            Console.WriteLine("Method 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass2 obj = new Myclass2();
            obj.method1();
            obj.method2();
            obj.M1();
        }
    }
}

