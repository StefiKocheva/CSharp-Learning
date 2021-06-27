namespace _07.FiguresArea
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var figure = Console.ReadLine();
            double area = 0;

            switch (figure)
            {
                case "square":
                    var side = double.Parse(Console.ReadLine());

                    area = side * side;
                    break;
                case "rectangle":
                    var firstSide = double.Parse(Console.ReadLine());
                    var secondSide = double.Parse(Console.ReadLine());

                    area = firstSide * secondSide;
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());

                    area = Math.PI * Math.Pow(radius, 2);
                    break;
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());

                    area = (triangleSide * height) / 2;
                    break;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
