namespace _01.Shapes
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(2, 2),
                new Rectangle(2, 2),
                new Square(5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
