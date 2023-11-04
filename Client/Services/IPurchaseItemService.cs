namespace PHDSolutions.Client.Services
{
    public interface IPurchaseItemService
    {
        List<PurchaseRecord> PurchaseItems { get; set; }

        Task GetPurchaseItems();
        Task<PurchaseRecord> CreatePurchaseRecord(PurchaseRecord purchaseRecord);
        Task<List<PurchaseRecord>> CreatePurchaseRecords(List<PurchaseRecord> purchaseRecords);
    }
}
