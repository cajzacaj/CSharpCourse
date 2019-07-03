using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceShapes
{
    class Triangle : Polygon
    {
        public override double GetArea()
        {
            double area = Height * Base / 2;

            return area;
        }
    }
}
