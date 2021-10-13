using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Figure
    {
        public string Type { get; }

        public Figure(string type)
        {
            Type = type;
        }

        public virtual double CalculateArea()
        {
            return -1;
        }
    }
}
