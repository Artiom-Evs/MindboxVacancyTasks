using MindboxVacancyTasks.Task2.Data;
using MindboxVacancyTasks.Task2.Models;
using MindboxVacancyTasks.Task2.Services;

namespace MindboxVacancyTasks.Task2;

internal static class Program
{
    static void Main(string[] args)
    {
        using StoreDbContext context = new();

        SeedData.EnsurePopulated(context);

        StoreService store = new(context);
        IQueryable<ProductCategoryRow> rows = store.GetProductsWithCategories();

        foreach (var result in rows)
        {
            Console.WriteLine($"{result.ProductName}\t{result.CategoryName}");
        }
    }
}
