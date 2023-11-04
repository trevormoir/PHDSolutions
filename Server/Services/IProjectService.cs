namespace PHDSolutions.Server.Services
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<ProjectRecord>>> GetProjects();
    }
}
