
using MindboxVacancyTasks.Task2.Models;

namespace MindboxVacancyTasks.Task2.Data;

public static class SeedData
{
    public static void EnsurePopulated(StoreDbContext context)
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
