using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceShapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            double pi = Math.PI;
            double area = pi * Radius * Radius;

            return area;
        }
        public override string ToString()
        {
            return "Circle";
        }
    }
}
