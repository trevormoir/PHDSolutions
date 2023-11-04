namespace PHDSolutions.Client.Services
{
    public interface IProjectService
    {
        List<ProjectRecord> Projects { get; set; }

        Task GetProjects();
    }
}
