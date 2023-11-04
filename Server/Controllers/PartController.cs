using Microsoft.AspNetCore.Mvc;

namespace PHDSolutions.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PartController : Controller
    {
        private readonly IPartService _partService;

        public PartController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MaterialMaster>>>> GetParts()
        {
            var result = await _partService.GetParts();
            return Ok(result);
        }

        [HttpGet("{partNumber}")]
        public async Task<ActionResult<ServiceResponse<MaterialMaster>>> GetPart(string partNumber)
        {
            var result = await _partService.GetPart(partNumber);
            return Ok(result);
        }
    }
}
