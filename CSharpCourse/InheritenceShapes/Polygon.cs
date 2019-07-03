using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceShapes
{
    class Polygon : Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double GetArea()
        {
            double area =  Height * Base;

            return area;
        }
    }
}
