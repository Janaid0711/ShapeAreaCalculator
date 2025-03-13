using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public abstract class Shape
    {
        public string Name { get; set; }

        //Constructor
        public Shape(string name)
        {
            Name = name;
        }

        //Create display
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}" );
        }
    }
}
