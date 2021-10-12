using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car cr = new Car("mers");
            //Car cr1 = new Car("ford", "fusion");
            //Car cr2 = new Car("Chevrolet", "cruze", 15000);

            //Console.WriteLine(cr.Car5());
            //Console.WriteLine(cr1.Car5());
            //Console.WriteLine(cr2.Car5());

            #region encapsulate
            //Teacheer t1 = new Teacheer();
            //t1.Age = 25;
            //Console.WriteLine(t1.Age);     

            Student s1 = new Student();
           
            Console.WriteLine("input Name");
            string text = Console.ReadLine();
            s1._name = text;
            Console.Clear();

            Console.WriteLine("input Surname");
            string text1 = Console.ReadLine();
            s1._surname = text1;
            Console.Clear();

            Console.WriteLine("input age");
            int age1 = int.Parse(Console.ReadLine());
            s1._age = age1;
            Console.Clear();

            Console.WriteLine("input number");
            int num = int.Parse(Console.ReadLine());
            s1.Mark = num;
            Console.WriteLine(s1.Mark);
            
           
            #endregion
        }

    }
}
