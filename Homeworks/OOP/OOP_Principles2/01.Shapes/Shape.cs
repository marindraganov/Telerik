namespace _01.Shapes
{
    public abstract class Shape
    {
        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }

        public abstract double CalculateSurface();
    }
}
