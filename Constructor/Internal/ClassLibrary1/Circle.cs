using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Circle:Figure
    {
        public int Radius;

        public Circle(int raidus,string type):base(type)
        {
            Radius = raidus;
        }

        public override double CalculateArea()
        {
           double area = Radius * (Math.PI * Math.PI);
            return area;
        }
    }
}
