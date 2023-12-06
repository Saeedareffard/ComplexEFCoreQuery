using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeLinq.Dtos;
using PracticeLinq.Interfaces;

namespace PracticeLinq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderReportController : ControllerBase
    {
    private readonly IOrderReportService _service;

    public OrderReportController(IOrderReportService service)
    {
        _service = service;
    }

    [HttpGet("GetReport")]
        public async  Task<List<OrderReportDto>> GetReport([FromQuery] int? year)
        {
            return await _service.GetOrdersReport(year);
        }

    }
}
