using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Name", "Surname", 32);
            Person p2 = new Person("Name", "Surname", 24);
            Person p3 = new Person("Name", "Surname", 17);
            Person[] persons = { p1, p2, p3 };

            Array.Sort(persons);

            foreach (Person item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
