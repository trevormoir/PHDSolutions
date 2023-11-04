using Microsoft.AspNetCore.Mvc;
using PHDSolutions.Server.Services;

namespace PHDSolutions.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProjectRecord>>>> GetProjects()
        {
            var result = await _projectService.GetProjects();
            return Ok(result);
        }
    }
}
