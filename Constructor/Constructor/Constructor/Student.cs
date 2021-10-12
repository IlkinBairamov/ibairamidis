using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Student
    {
        public string _name;
        public string _surname;
        public int _age;

        public int _mark;

        public int Mark
        {
            get
            {
                if (_mark>0 && _mark<100)
                {
                    return _mark;                    
                }
                return -1;
            }
            set
            {
                if (value>0 && value<100)
                {
                    _mark = value;
                    return;
                }
                Console.WriteLine("Incorrect!");
            }
        }


       public void Any()
        {
            return $"{_name} { _surname} {_age} {_mark}";
        }

    }

     

    
}
