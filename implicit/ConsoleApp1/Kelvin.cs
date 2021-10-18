using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }

    }
}
