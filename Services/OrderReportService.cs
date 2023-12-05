using PracticeLinq.Contexts;
using PracticeLinq.Dtos;

namespace PracticeLinq.Services;

public class OrderReportService
{
    private readonly ApplicationDbContext _context;

    public OrderReportService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<OrderReportDto>> GetOrdersReport(int? year)
    {
        var reportYear = year ?? DateTime.Now.AddYears(-1).Year;

        var customerTopProducts = _context.OrderDetails
            .Where(od => od.Order.OrderDate.Year == reportYear)
            .GroupBy(od => new { od.Order.CustomerID, od.ProductID })
            .Select(g => new { g.Key.CustomerID, g.Key.ProductID, TotalQuantity = g.Sum(od => od.Quantity) })
            .OrderByDescending(g => g.TotalQuantity)
            .AsEnumerable()
            .GroupBy(g => g.CustomerID)
            .Select(g => new
            {
                CustomerID = g.Key,
                TopProducts = g.Take(3).ToList()
            })
            .ToList()
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