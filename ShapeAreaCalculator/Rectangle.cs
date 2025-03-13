using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Rectangle:Shape, ICalculateArea
    {
        public double Width { get; set; }

        public double Height { get; set; }

        //Constructor
        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        //Method to calculate area
        public double CalculateArea()
        {
            return Width * Height;
        }

        //Override Display method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Width: {Width} ,Height: {Height}, Area: {CalculateArea()}");
        }
    }
}
