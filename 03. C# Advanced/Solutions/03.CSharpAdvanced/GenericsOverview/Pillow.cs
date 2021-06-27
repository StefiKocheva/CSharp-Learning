namespace GenericsOverview
{
    public class Pillow
    {
        public Pillow(string color, int width, int length)
        {
            this.Color = color;
            this.Width = width;
            this.Length = length;
        }

        public string Color { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
    }
}
