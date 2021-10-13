using System;
using ClassLibrary1;
namespace Internal
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10, "Circle");
            Rectangle r1 = new Rectangle(15, 10, "Rectangle");

            #region Circle Area

            Console.WriteLine("input Radius");
            int numb = int.Parse(Console.ReadLine());
            c1.Radius = numb;
            Console.WriteLine(c1.CalculateArea());
            
            #endregion

            #region Rectangle Area
            Console.WriteLine("input Width");
            int numb1 = int.Parse(Console.ReadLine());
            r1.Length = numb1;
            Console.WriteLine("input Length");
            int numb2 = int.Parse(Console.ReadLine());
            r1.Width = numb2;
            Console.WriteLine(r1.CalculateArea());
            #endregion


        }
    }
}
