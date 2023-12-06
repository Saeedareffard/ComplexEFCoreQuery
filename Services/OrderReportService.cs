using Microsoft.EntityFrameworkCore;
using PracticeLinq.Contexts;
using PracticeLinq.Dtos;
using PracticeLinq.Interfaces;

namespace PracticeLinq.Services;

public class OrderReportService : IOrderReportService
{
    private readonly ApplicationDbContext _context;

    public OrderReportService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<OrderReportDto>> GetOrdersReport(int? year)
    {
        var reportYear = year ?? DateTime.Now.AddYears(-1).Year;

        // Execute the query and materialize the results as late as possible
        var query = _context.OrderDetails
            .Where(od => od.Order.OrderDate.Year == reportYear)
            .GroupBy(od => new { od.Order.CustomerID, od.ProductID })
            .Select(g => new { g.Key.CustomerID, g.Key.ProductID, TotalQuantity = g.Sum(od => od.Quantity) })
            .OrderByDescending(g => g.TotalQuantity)
            .GroupBy(g => g.CustomerID)
            .Select(g => new
            {
                CustomerID = g.Key,
                TopProducts = g.Take(3) // Avoid ToList here to prevent premature materialization
            });

        // Materialize the results into memory efficiently with a single call to ToListAsync
        var groupedResults = await query.ToListAsync();

        // Map the results to the DTO after materialization
        var customerTopProducts = groupedResults
            .Select(g => new OrderReportDto
            {
                CustomerId = g.CustomerID,
                FistTopProductId = g.TopProducts.ElementAtOrDefault(0)?.ProductID,
                FirstProductQuantity = g.TopProducts.ElementAtOrDefault(0)?.TotalQuantity,
                SecondTopProductId = g.TopProducts.ElementAtOrDefault(1)?.ProductID,
                SecondProductQuantity = g.TopProducts.ElementAtOrDefault(1)?.TotalQuantity,
                ThirdTopProductId = g.TopProducts.ElementAtOrDefault(2)?.ProductID,
                ThirdProductQuantity = g.TopProducts.ElementAtOrDefault(2)?.TotalQuantity
            })
            .ToList();

        return customerTopProducts;
    }

}