using Microsoft.AspNetCore.Mvc;

namespace PHDSolutions.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<string>>>> GetReport()
        {
            var result = await _reportService.GetReport();
            return Ok(result);
        }
    }
}
