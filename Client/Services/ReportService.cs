namespace PHDSolutions.Client.Services
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _httpClient;

        public ReportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<string> Report { get; set; } = new List<string>();
        public string Message { get; set; } = "Loading services...";

        public async Task GetReport()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>("api/report");
            if (result != null && result.Data != null)
                Report = result.Data;

            Console.WriteLine($"Report.Count: {Report.Count}");
            if (Report.Count == 0) Message = "No services found.";
        }
    }
}