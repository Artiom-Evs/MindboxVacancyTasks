
using MindboxVacancyTasks.Task1.Models;

namespace MindboxVacancyTasks.Task1.Tests;

public class GeneralTests
{
    [Test]
    public void TestAreaCalculationForAbstractShapes()
    {
        ShapeBase[] shapes =
        [
            new Triangle(3, 4, 5),
            new Circle(10)
        ];
        double[] areas =
        [
            6,
            314.15926535897933d
        ];

        double[] results = shapes.Select(s => s.CalculateArea()).ToArray();

        Assert.That(results, Is.EqualTo(areas));
    }
}
