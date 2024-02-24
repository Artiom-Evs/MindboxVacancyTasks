
namespace MindboxVacancyTasks.Task1.Models;

public class Circle : ShapeBase
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; init; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
