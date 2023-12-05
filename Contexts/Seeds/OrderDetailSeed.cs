using Microsoft.EntityFrameworkCore;
using PracticeLinq.Models;

namespace PracticeLinq.Contexts.Seeds;

public static class OrderDetailSeedingExtension
{
    public static void AddOrderDetailSeed(this ModelBuilder builder)
    {
        OrderDetail[] orderDetails =
        {
            new() { OrderID = 3, ProductID = 103, Quantity = 5 },
            new() { OrderID = 3, ProductID = 104, Quantity = 3 },
            new() { OrderID = 3, ProductID = 105, Quantity = 3 },
            new() { OrderID = 4, ProductID = 105, Quantity = 2 },
            new() { OrderID = 4, ProductID = 106, Quantity = 4 },
            new() { OrderID = 5, ProductID = 101, Quantity = 1 },
            new() { OrderID = 5, ProductID = 102, Quantity = 2 },
            new() { OrderID = 6, ProductID = 103, Quantity = 3 },
            new() { OrderID = 6, ProductID = 104, Quantity = 1 },
            new() { OrderID = 7, ProductID = 105, Quantity = 4 },
            new() { OrderID = 7, ProductID = 106, Quantity = 2 },
            new() { OrderID = 8, ProductID = 101, Quantity = 3 },
            new() { OrderID = 8, ProductID = 102, Quantity = 5 },
            new() { OrderID = 9, ProductID = 103, Quantity = 2 },
            new() { OrderID = 9, ProductID = 104, Quantity = 1 },
            new() { OrderID = 10, ProductID = 105, Quantity = 3 },
            new() { OrderID = 10, ProductID = 106, Quantity = 2 },
            new() { OrderID = 11, ProductID = 101, Quantity = 4 },
            new() { OrderID = 11, ProductID = 102, Quantity = 1 },
            new() { OrderID = 12, ProductID = 103, Quantity = 5 },
            new() { OrderID = 12, ProductID = 104, Quantity = 2 }

        };
        builder.Entity<OrderDetail>().HasData(orderDetails);
    }
}