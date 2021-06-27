namespace _01.Shapes
{
    using System;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            if (this.height == 1 && this.width == 1)
            {
                Console.WriteLine("*");

                return;
            }

            if (this.width == 1)
            {
                for (int i = 0; i < this.height; i++)
                {
                    Console.WriteLine("*");
                }

                return;
            }

            if (this.height == 1)
            {
                Console.WriteLine(new string('*', this.width));

                return;
            }

            Console.WriteLine(new string('*', this.width));

            for (int i = 0; i < this.height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', this.width - 2) + "*");
            }

            Console.WriteLine(new string('*', this.width));

        }
    }
}