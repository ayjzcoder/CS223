using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Square : Shape
    {
        public double  length { get; set; }
        public override double calculate_area()
        {
            return length*length;
        }

        public override double calculate_perimeter()
        {
            return length*4;
        }
    }

}
