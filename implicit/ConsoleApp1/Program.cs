using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kelvin k1 = new Kelvin(20);   
            Celsius c1 = k1;

            Celsius c2 = new Celsius(100);
            Kelvin k2 = (Kelvin)c2;
            
            Console.WriteLine(c1.Degree);
            Console.WriteLine(k2.Degree);


        }
    }
}
