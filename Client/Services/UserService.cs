namespace PHDSolutions.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<User> Users { get; set; } = new List<User>();
        public string Message { get; set; } = "Loading services...";

        public async Task GetUsers()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<User>>>("api/user");
            if (result != null && result.Data != null)
                Users = result.Data;

            Console.WriteLine($"Users.Count: {Users.Count}");
            if (Users.Count == 0) Message = "No services found.";
        }
    }
}