
using Microsoft.EntityFrameworkCore;
using MindboxVacancyTasks.Task2.Data;
using MindboxVacancyTasks.Task2.Models;

namespace MindboxVacancyTasks.Task2.Services;

public class StoreService
{
    private readonly StoreDbContext _context;


    private const string GET_PRODUCTS_WITH_CATEGORIES = @"
SELECT
    Products.Name AS ProductName,
    Categories.Name AS CategoryName
from Products
FULL JOIN CategoryProduct
    ON Products.Id = CategoryProduct.ProductsId
LEFT JOIN Categories
    ON CategoryProduct.CategoriesId = Categories.Id
ORDER BY Products.Id, Categories.Id
";


    public StoreService(StoreDbContext context)
    {
        _context = context;
    }

    public IQueryable<ProductCategoryRow> GetProductsWithCategories()
    {
        return _context.Database.SqlQueryRaw<ProductCategoryRow>(GET_PRODUCTS_WITH_CATEGORIES, []);
    }
}
