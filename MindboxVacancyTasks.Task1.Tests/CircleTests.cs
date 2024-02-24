using MindboxVacancyTasks.Task1.Models;

namespace MindboxVacancyTasks.Task1.Tests;

public class CircleTests
{
    [TestCase(10, 314.15926535897933d)]
    public void CalculateCircleArea(double radius, double expected)
    {
        Circle circ = new(radius);

        double result = circ.CalculateArea();

        Assert.That(result, Is.EqualTo(expected));
    }
}
