using System;
using static System.Console;
using System.Collections;

namespace Interface_multi_Inheritance
{
    interface Iinterface1{
        void language();
    }
    class Program1:Iinterface1
    {
        public void language(){
            ArrayList mylist = new ArrayList();
            //adding elements in mylist array
            mylist.Add("C");
            mylist.Add("C#");
            mylist.Add("Python");
            mylist.Add("Java");
            WriteLine("\n*******Language You need to Know :********");
            foreach (var elements in mylist)
            {
                WriteLine(elements);
            }
        }
    }
    interface Iinterface2{
        void courses();
    }
    class Program2:Iinterface2{
        public void courses(){
            ArrayList mylist = new ArrayList();
            mylist.Add("C fundamentals");
            mylist.Add("C# classes");
            mylist.Add("Python for data science");
            mylist.Add("Java for applications");
            WriteLine("\n*******Courses provided by Programming languages****** ");
            foreach (var elements in mylist)
            {
                WriteLine(elements);
            }
        }
    
    }

    class Program: Iinterface1, Iinterface2{
        Program1 obj1 = new Program1();
        Program2 obj2 = new Program2();
        public void language(){
            obj1.language();
        }
        public void courses(){
            obj2.courses();
        }
    }
    class main_Class{
        static void Main(string[] args){
            Program obj = new Program();
            obj.language();
            obj.courses();
        }

    }
}
