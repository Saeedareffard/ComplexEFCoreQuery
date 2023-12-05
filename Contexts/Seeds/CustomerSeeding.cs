using Microsoft.EntityFrameworkCore;
using PracticeLinq.Models;

namespace PracticeLinq.Contexts.Seeds;

public static class CustomerSeedingExtension
{
    public static void AddCustomerSeed(this ModelBuilder builder)
    {
        Customer[] customers =
        {
            new() { CustomerID = 1, Name = "Saeed" },
            new() { CustomerID = 2, Name = "Alex" },
            new() { CustomerID = 3, Name = "James" }
        };
        builder.Entity<Customer>().HasData(customers
        );
    }
}