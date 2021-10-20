using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //public static bool operator >(Person p1, Person p2)
        //{
        //    return p1.Age > p2.Age;
        //}
        //public static bool operator <(Person p1, Person p2)
        //{
        //    return p1.Age < p2.Age;
        //}

        //public static Person[] Sort(Person[] persons)
        //{
        //    for (int i = 0; i < persons.Length; i++)
        //    {
        //        for (int j = i + 1; j < persons.Length; j++)
        //        {
        //            if (persons[i] > persons[j])
        //            {
        //                Person temp = persons[i];
        //                persons[i] = persons[j];
        //                persons[j] = temp;

        //            }
        //        }
        //    }

        //    return persons;
        //}

    }
}
