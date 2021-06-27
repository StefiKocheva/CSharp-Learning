namespace _03.Shapes
{
    using System;
    using System.Text;

    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException("The height should be longer than 0.");
            }
            else
            {
                this.height = height;
            }

            if (width < 0)
            {
                throw new ArgumentOutOfRangeException("The width should be longer than 0.");
            }
            else
            {
                this.width = width;
            }
        }

        public override double CalculateArea() => this.height * this.width;

        public override double CalculatePerimeter() => (this.height + this.width) * 2;

        public override string Draw()
        {
            var sb = new StringBuilder();

            if (this.height == 1 && this.width == 1)
            {
                return "*";
            }

            if (this.height == 1)
            {
                return new string('*', this.width);
            }

            if (this.width == 1)
            {
                for (int i = 0; i < this.height; i++)
                {
                    sb.AppendLine("*");
                }

                return sb.ToString();
            }

            sb.AppendLine(new string('*', this.width));

            for (int i = 0; i < this.height - 2; i++)
            {
                sb.AppendLine(new string("*" + new string(' ', this.width - 2)) + "*");
            }

            sb.AppendLine(new string('*', this.width));

            return sb.ToString();
        }
    }
}
