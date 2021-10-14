using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public readonly string Name;
        public readonly string Surname;
        public readonly int Age;
        private static int Counter1;
        public static int Counter
        {
            get
            {
                return Counter1;
            }
        }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;           
            Counter1++;
        }


        public static int CounterCalc()
        {
            return Counter1;
        }
            
    }
}



