using MindboxVacancyTasks.Task2.Data;
using MindboxVacancyTasks.Task2.Models;
using MindboxVacancyTasks.Task2.Services;

namespace MindboxVacancyTasks.Task2.Tests;

public class StoreServiceTests
{
    [Test]
    public void GetProductsWithRows()
    {
        using StoreDbContext context = new();
        StoreService store = new(context);
        ProductCategoryRow[] expected =
        [
            new("Laptop", "Electronics"),
            new("Printer", "Electronics"),
            new("Printer", "Office equipment"),
            new("Pineapple", null),
        ];

        EnsurePopulated(context);

        ProductCategoryRow[] result = store.GetProductsWithCategories().ToArray();

        Assert.That(result, Is.EqualTo(expected));
    }

    private void EnsurePopulated(StoreDbContext context)
    {
        Product[] products =
        [
            new() { Name = "Laptop" },
            new() { Name = "Printer" },
            new() { Name = "Pineapple" }
        ];
        Category[] categories =
        [
            new() { Name = "Electronics" },
            new() { Name = "Office equipment" }
        ];

        products[0].Categories.Add(categories[0]);
        products[1].Categories.Add(categories[0]);
        products[1].Categories.Add(categories[1]);

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}