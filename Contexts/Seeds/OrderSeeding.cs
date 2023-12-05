using Microsoft.EntityFrameworkCore;
using PracticeLinq.Models;

namespace PracticeLinq.Contexts.Seeds;

public static class OrderSeedingExtension
{
    public static void AddOrderSeed(this ModelBuilder builder)
    {
        Order[] orders =
        {
            new() { OrderID = 3, CustomerID = 3, OrderDate = new DateTime(2021, 3, 1) },
            new() { OrderID = 4, CustomerID = 1, OrderDate = new DateTime(2021, 4, 1) },
            new() { OrderID = 5, CustomerID = 2, OrderDate = new DateTime(2021, 5, 1) },
            new() { OrderID = 6, CustomerID = 3, OrderDate = new DateTime(2021, 6, 1) },
            new() { OrderID = 7, CustomerID = 1, OrderDate = new DateTime(2021, 7, 1) },
            new() { OrderID = 8, CustomerID = 2, OrderDate = new DateTime(2021, 8, 1) },
            new() { OrderID = 9, CustomerID = 3, OrderDate = new DateTime(2021, 9, 1) },
            new() { OrderID = 10, CustomerID = 1, OrderDate = new DateTime(2021, 10, 1) },
            new() { OrderID = 11, CustomerID = 2, OrderDate = new DateTime(2021, 11, 1) },
            new() { OrderID = 12, CustomerID = 3, OrderDate = new DateTime(2021, 12, 1) },
            new() { OrderID = 13, CustomerID = 1, OrderDate = new DateTime(2022, 1, 1) },
            new() { OrderID = 14, CustomerID = 2, OrderDate = new DateTime(2022, 2, 1) },
            new() { OrderID = 15, CustomerID = 3, OrderDate = new DateTime(2022, 3, 1) },
            new() { OrderID = 16, CustomerID = 1, OrderDate = new DateTime(2022, 4, 1) },
            new() { OrderID = 17, CustomerID = 2, OrderDate = new DateTime(2022, 5, 1) },
            new() { OrderID = 18, CustomerID = 3, OrderDate = new DateTime(2022, 6, 1) },
            new() { OrderID = 19, CustomerID = 1, OrderDate = new DateTime(2022, 7, 1) },
            new() { OrderID = 20, CustomerID = 2, OrderDate = new DateTime(2022, 8, 1) },
            new() { OrderID = 21, CustomerID = 3, OrderDate = new DateTime(2022, 9, 1) },
            new() { OrderID = 22, CustomerID = 1, OrderDate = new DateTime(2022, 10, 1) }

            // ... more orders
        };
        builder.Entity<Order>().HasData(orders);
    }
}