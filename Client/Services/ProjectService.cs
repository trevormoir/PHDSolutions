namespace PHDSolutions.Client.Services
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<ProjectRecord> Projects { get; set; } = new List<ProjectRecord>();
        public string Message { get; set; } = "Loading services...";

        public async Task GetProjects()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProjectRecord>>>("api/project");
            if (result != null && result.Data != null)
                Projects = result.Data;

            Console.WriteLine($"Projects.Count: {Projects.Count}");
            if (Projects.Count == 0) Message = "No services found.";
        }
    }
}