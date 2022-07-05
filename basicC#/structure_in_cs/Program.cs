using System;
using static System.Console;

namespace structure_in_cs
{
    struct Employee{
        public int id;
        public void getId(int id){
            WriteLine("Employee id is "+id);
        }

    }
    class Program{
        static void Main(string[] args){
            Employee emp = new Employee();
            emp.id = 1;
            emp.getId(emp.id);
        }
    }

}
