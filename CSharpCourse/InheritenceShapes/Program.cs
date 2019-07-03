using System;
using System.Collections.Generic;
using CSharpCourse.Utilities;

namespace InheritenceShapes
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            List<Shape> allShapes = AskForListOfShapes();
            PrintAllShapes(allShapes);
            PrintAllAreas(allShapes);
        }

        private static void PrintAllAreas(List<Shape> shapeList)
        {
            double totalArea = 0;

            Console.WriteLine();
            ch.Columns(ConsoleColor.DarkCyan, "Type", "Area");
            foreach (var shape in shapeList)
            {
                ch.Columns(ConsoleColor.DarkGray, shape.ToString(), Math.Round(shape.GetArea()));
                totalArea += shape.GetArea();
            }
            ch.Columns(ConsoleColor.DarkGray, "Total area:", Math.Round(totalArea, 2));
        }

        private static List<Shape> AskForListOfShapes()
        {
            var listOfShapes = new List<Shape>();

            while (true)
            {
                char command = ch.AskForKey("Select (T)riangle, (R)ektangle, (C)ircle or (D)one:");
                ch.Space();

                switch (command)
                {
                    case 'T':
                        listOfShapes.Add(AskForTriangle());
                        break;
                    case 'R':
                        listOfShapes.Add(AskForRectangle());
                        break;
                    case 'C':
                        listOfShapes.Add(AskForCirle());
                        break;
                    case 'D':
                        return listOfShapes;
                }
            }
        }

        private static Circle AskForCirle()
        {
            var circle = new Circle();
            circle.Radius = ch.AskForDouble("Enter radius of circle:");

            return circle;
        }

        private static Rectangle AskForRectangle()
        {
            var rectangle = new Rectangle();
            rectangle.Base = ch.AskForDouble("Enter base of rectangle:");
            rectangle.Height = ch.AskForDouble("Enter height of rectangle:");

            return rectangle;
        }

        private static Triangle AskForTriangle()
        {
            var triangle = new Triangle();
            triangle.Base = ch.AskForDouble("Enter base of triangle:");
            triangle.Height = ch.AskForDouble("Enter height of triangle:");

            return triangle;
        }

        private static void PrintAllShapes(List<Shape> shapeList)
        {
            foreach (var shape in shapeList)
            {

                if (shape is Circle)
                {
                    Circle circle = shape as Circle;
                    ch.WriteLineDark($"I'm a circle with radius = {circle.Radius}");
                }
                if (shape is Triangle)
                {
                    Triangle triangle = shape as Triangle;
                    ch.WriteLineDark($"I'm a triangle with base length = {triangle.Base} and heigth = {triangle.Height}");
                }
                if (shape is Rectangle)
                {
                    Rectangle rectangle = shape as Rectangle;
                    ch.WriteLineDark($"I'm a rectangle with base length = {rectangle.Base} and heigth = {rectangle.Height}");
                }
            }

        }
    }
}
