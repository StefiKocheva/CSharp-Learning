namespace _03.Shapes
{
    using System;
    using System.Text;

    public static class Startup
    {
        public static void Main()
        {
            Shape rectangle = new Rectangle(5, 4);
            
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Shape circle = new Circle(5);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
