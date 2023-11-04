using Microsoft.AspNetCore.Mvc;
using PHDSolutions.Shared;

namespace PHDSolutions.Server.Services
{
    public interface IPurchaseItemService
    {
        Task<ServiceResponse<List<PurchaseRecord>>> GetPurchaseItems();
        Task<ServiceResponse<PurchaseRecord>> CreatePurchaseItem(PurchaseRecord purchaseRecord);
        Task<ServiceResponse<List<PurchaseRecord>>> CreatePurchaseItems(List<PurchaseRecord> purchaseRecords);
    }
}
