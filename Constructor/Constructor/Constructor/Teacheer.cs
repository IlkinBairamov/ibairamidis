
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Teacheer
    {
        public string Name { get; private set; }
        public string Surname { get; set; }       
        public string Departmen { get; set; }

        private int _age;
        
        public int Age
        {
            get
            {
                if (_age > 20)
                return _age;
                return -1;
            }
            set
            {
                    if (value>20)
                    {
                       _age = value;
                        return;
                    }
                    Console.WriteLine("bu yasda muellim olmaz!");
            }
        }

        //public int GetAge()
        //{
        //    if (Age > 20)
        //        return Age;
        //    return -1;
        //}

        //public void Setage(int age)
        //{
        //    if (age>20)
        //    {
        //        Age = age;
        //        return;
        //    }
        //    Console.WriteLine("bu yasda muellim olmaz!");
        //}
      
    }
}
