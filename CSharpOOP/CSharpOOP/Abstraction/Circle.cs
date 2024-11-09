namespace CSharpOOP.Abstraction
{
    internal class Circle(double radius) : Shape
    {
        public double Radius { get; set; } = radius;

        // Implementasi dari CalculateArea() di kelas Circle
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
