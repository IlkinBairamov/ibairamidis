using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car("mers");
            Car cr1 = new Car("ford", "fusion");
            Car cr2 = new Car("Chevrolet", "cruze", 15000);

            Console.WriteLine(cr.Car5());
            Console.WriteLine(cr1.Car5());
            Console.WriteLine(cr2.Car5());
        }

       
       
        


    }
}
