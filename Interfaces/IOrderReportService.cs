using PracticeLinq.Dtos;

namespace PracticeLinq.Interfaces
{
    public interface IOrderReportService
    {
        List<OrderReportDto> GetOrdersReport(int? year);
    }
}
