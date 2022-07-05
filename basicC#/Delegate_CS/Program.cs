using System;
using System.Collections;

namespace Delegate_CS
{
    public delegate void myDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);


            del = (string msg) => Console.WriteLine("Calling Lambda expression "+msg);
            InvokeDelegate(del);
        }
        static void InvokeDelegate(myDelegate del){
            del("Hello World");
        }
    }
    class ClassA{
        static void MethodA(string message){
            Console.WriteLine("Called ClassA.MethodA() with parameter "+message);
        }
    }
    class ClassB{
        static void MethodB(string message){
            Console.WriteLine("Called ClassB.MethodB() with parameter "+message);
        }
    }
}
