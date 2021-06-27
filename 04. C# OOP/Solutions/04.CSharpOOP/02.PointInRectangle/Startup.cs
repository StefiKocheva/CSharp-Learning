namespace _02.PointInRectangle
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            var rectangleCoordinates = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rectangle = new Rectangle(
                rectangleCoordinates[0],
                rectangleCoordinates[1],
                rectangleCoordinates[2],
                rectangleCoordinates[3]);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var pointCoordinates = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                var point = new Point(
                    pointCoordinates[0],
                    pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
