namespace _02.PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeft.X = topLeftX;
            this.TopLeft.Y = topLeftY;

            this.BottomRight.X = bottomRightX;
            this.BottomRight.Y = bottomRightY;
        }

        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            var biggerX = TopLeft.X > BottomRight.X ? TopLeft.X : BottomRight.X;
            var smallerX = TopLeft.X < BottomRight.X ? TopLeft.X : BottomRight.X;

            var biggerY = TopLeft.Y > BottomRight.Y ? TopLeft.Y : BottomRight.Y;
            var smallerY = TopLeft.Y < BottomRight.Y ? TopLeft.Y : BottomRight.Y;

            bool conditionByX = biggerX >= point.X && smallerX <= point.X;
            bool conditionByY = biggerY >= point.Y && smallerY <= point.Y;

            return conditionByX && conditionByY;
        }
    }
}
