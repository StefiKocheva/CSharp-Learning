﻿namespace _11.RefactorVolumeОfPyramid
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
