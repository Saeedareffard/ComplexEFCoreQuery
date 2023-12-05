using Microsoft.EntityFrameworkCore;
using PracticeLinq.Models;

namespace PracticeLinq.Contexts.Seeds;

public static class ProductSeedingExtension
{
    public static void AddProductSeed(this ModelBuilder builder)
    {
        Product[] products =
        {
            new() { ProductID = 101, Name = "Widget A" },
            new() { ProductID = 103, Name = "Widget C" },
            new() { ProductID = 104, Name = "Widget D" },
            new() { ProductID = 105, Name = "Widget E" },
            new() { ProductID = 106, Name = "Widget F" },
            new() { ProductID = 102, Name = "Widget B" }
        };
        builder.Entity<Product>().HasData(products);
    }
}