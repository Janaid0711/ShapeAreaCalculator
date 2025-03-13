using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Circle: Shape, ICalculateArea
    {
        public double Radius { get; set; }
        //Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        //Method to calculate area
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        //Override Display method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea()}");
        }
    }
}
