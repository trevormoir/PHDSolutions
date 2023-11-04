namespace PHDSolutions.Client.Services
{
    public class PartService : IPartService
    {
        private readonly HttpClient _httpClient;

        public PartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<MaterialMaster> Parts { get; set; } = new List<MaterialMaster>();
        public string Message { get; set; } = "Loading services...";

        public async Task GetParts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<MaterialMaster>>>("api/part");
            if (result != null && result.Data != null)
                Parts = result.Data;

            Console.WriteLine($"Parts.Count: {Parts.Count}");
            if (Parts.Count == 0) Message = "No services found.";
        }
    }
}