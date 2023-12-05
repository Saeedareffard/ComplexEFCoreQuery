using Microsoft.Extensions.Caching.Memory;
using PracticeLinq.Dtos;
using PracticeLinq.Interfaces;

namespace PracticeLinq.Services;

public class CashedReportRepository : IOrderReportService
{
    private readonly IOrderReportService _orderReportService;
    private readonly IMemoryCache _memoryCache;

    public CashedReportRepository(IOrderReportService orderReportService, IMemoryCache memoryCache)
    {
        _orderReportService = orderReportService;
        _memoryCache = memoryCache;
    }

    public List<OrderReportDto> GetOrdersReport(int? year)
    {
        var reportYear = year ?? DateTime.Now.AddYears(-1).Year;
        var key = $"the year - {reportYear.ToString()}";
        return _memoryCache.GetOrCreate(
            key,
            entry => {
                entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
                return _orderReportService.GetOrdersReport(reportYear);
            })!;
    }
}