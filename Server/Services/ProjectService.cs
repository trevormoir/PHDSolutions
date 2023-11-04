namespace PHDSolutions.Server.Services
{
    public class ProjectService : IProjectService
    {
        private readonly PHDSolutionsContext _context;

        public ProjectService(PHDSolutionsContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<ProjectRecord>>> GetProjects()
        {
            var projects = await _context.ProjectRecord.ToListAsync();

            return new ServiceResponse<List<ProjectRecord>> { Data = projects };
        }

        public async Task<ServiceResponse<ProjectRecord>> GetProject(string projectNumber)
        {
            var project = await _context.ProjectRecord.FirstOrDefaultAsync(p => p.projectNumber == projectNumber);

            return new ServiceResponse<ProjectRecord> { Data = project };
        }
    }
}