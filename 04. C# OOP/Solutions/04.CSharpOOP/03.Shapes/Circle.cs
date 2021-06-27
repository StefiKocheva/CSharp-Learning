namespace _03.Shapes
{
    using System;
    using System.Text;

    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("The radius should be longer than 0.");
            }
            else
            {
                this.radius = radius;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;

            StringBuilder sb = new StringBuilder();

            for (double y = this.radius; y >= -this.radius; --y)
            {
                for (double x = -this.radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    sb.Append(
                        value >= rIn * rIn && value <= rOut * rOut
                        ? "*"
                        : " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
