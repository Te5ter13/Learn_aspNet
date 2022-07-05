using System;
using static System.Console;
namespace constructorEg
{
    class Car
    {
        string CarModel;
        int CarYear;
        public Car(int Year, string Model){
            CarModel = Model;
            CarYear = Year;
        }
        // Showing Overloading
        public Car(string Model, int Year){
            CarModel = Model;
            CarYear = Year;
        }

        static void Main(string[] args)
        {
            Car obj = new Car(1996,"Mustang");
            WriteLine("Car Model:"+obj.CarModel);
            WriteLine("Car Year:"+obj.CarYear);
            
            WriteLine("\nOverloading Example");
            Car newCar = new Car("Impala", 1967); //Invoking Overloading method
            WriteLine("Car Model:"+newCar.CarModel);
            WriteLine("Car Year"+newCar.CarYear);    
        }
    }
}
