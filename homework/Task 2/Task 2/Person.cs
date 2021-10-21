using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Person : ICompare
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp != null)
            {
                if (this.Age > temp.Age)
                    return 1;
                if (this.Age < temp.Age)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Person deyil!");
        }
        public Person(string name, string surname, int age) : base()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
