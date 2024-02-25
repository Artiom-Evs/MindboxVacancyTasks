
using Microsoft.EntityFrameworkCore;
using MindboxVacancyTasks.Task2.Models;

namespace MindboxVacancyTasks.Task2.Data;

public class StoreDbContext : DbContext
{
    public StoreDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = @"Filename=""store.db""";
            
        optionsBuilder.UseSqlite(connectionString);
    }
}
