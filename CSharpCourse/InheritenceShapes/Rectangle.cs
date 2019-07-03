using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceShapes
{
    class Rectangle : Polygon
    {
        public override double GetArea()
        {
            double area = Height * Base;

            return area;
        }
    }
}
