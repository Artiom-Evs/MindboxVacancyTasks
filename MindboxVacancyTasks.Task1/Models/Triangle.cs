namespace MindboxVacancyTasks.Task1.Models;

public class Triangle : ShapeBase
{
    public Triangle(double side1Length, double side2Length, double side3Length)
    {
        Side1Length = side1Length;
        Side2Length = side2Length;
        Side3Length = side3Length;
    }

    public double Side1Length { get; init; }
    public double Side2Length { get; init; }
    public double Side3Length { get; init; }

    public double Perimeter => Side1Length + Side2Length + Side3Length;

    public override double CalculateArea()
    {
        double p = Perimeter / 2;
        double area = Math.Sqrt(p * (p - Side1Length) * (p - Side2Length) * (p - Side3Length));
        return area;
    }
}
