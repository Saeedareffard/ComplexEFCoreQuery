using PracticeLinq.Dtos;

namespace PracticeLinq.Interfaces
{
    public interface IOrderReportService
    {
        Task<List<OrderReportDto>> GetOrdersReport(int? year);
    }
}
