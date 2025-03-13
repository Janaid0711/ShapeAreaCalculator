namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create objects
            Rectangle rectangle = new Rectangle("Rectangle", 10, 20);
            rectangle.Display();

            Console.WriteLine(); //Leave a Line

            Circle circle = new Circle("Circle", 10);
            circle.Display();
        }
    }
}
