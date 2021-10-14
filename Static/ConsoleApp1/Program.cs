using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("name","surname",22);
            Student s2 = new Student("name", "surname", 23);
            Student s3 = new Student("name", "surname", 24);
            Student s5 = new Student("name", "surname", 25);


            Console.WriteLine(Student.CounterCalc());
            Console.WriteLine(Student.Counter);

        }
    }
}
