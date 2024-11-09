namespace CSharpOOP.Abstraction
{
    internal class Rectangle(double width, double height) : Shape
    {
        public double Width { get; set; } = width;
        public double Height { get; set; } = height;

        // Implementasi dari CalculateArea() di kelas Rectangle
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
