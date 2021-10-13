using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public Rectangle(int width,int length,string type):base(type)
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea()
        {
            double area = Width * Length;

            return area;
        }
    }
}
