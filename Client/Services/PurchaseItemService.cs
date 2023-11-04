namespace PHDSolutions.Client.Services
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private readonly HttpClient _httpClient;

        public PurchaseItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<PurchaseRecord> PurchaseItems { get; set; } = new List<PurchaseRecord>();
        public string Message { get; set; } = "Loading services...";

        public async Task GetPurchaseItems()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<PurchaseRecord>>>("api/purchaseitem");
            if (result != null && result.Data != null)
                PurchaseItems = result.Data;

            Console.WriteLine($"Users.Count: {PurchaseItems.Count}");
            if (PurchaseItems.Count == 0) Message = "No services found.";
        }

        public async Task<PurchaseRecord> CreatePurchaseRecord(PurchaseRecord purchaseRecord)
        {
            var result = await _httpClient.PostAsJsonAsync("api/purchaseitem/additem", purchaseRecord);
            var newPurchaseRecord = (await result.Content.ReadFromJsonAsync<ServiceResponse<PurchaseRecord>>()).Data;
            return newPurchaseRecord;
        }

        public async Task<List<PurchaseRecord>> CreatePurchaseRecords(List<PurchaseRecord> purchaseRecords)
        {
            var result = await _httpClient.PostAsJsonAsync("api/purchaseitem", purchaseRecords);
            var newPurchaseRecords = (await result.Content.ReadFromJsonAsync<ServiceResponse<List<PurchaseRecord>>>()).Data;
            return newPurchaseRecords;
        }
    }
}