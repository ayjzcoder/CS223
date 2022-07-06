using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Circle : Shape
    {
        public double radius { get; 
            set ; }
        static  readonly double pi = 3.14;
        public override double calculate_area()
        {
          return pi*radius*radius;
        }

        public override double calculate_perimeter()
        {
            return 2 * pi * radius;

        }
    }
}
