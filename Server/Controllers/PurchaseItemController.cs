using Microsoft.AspNetCore.Mvc;

namespace PHDSolutions.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PurchaseItemController : Controller
    {
        private readonly IPurchaseItemService _purchaseItemService;

        public PurchaseItemController(IPurchaseItemService purchaseItemService)
        {
            _purchaseItemService = purchaseItemService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<PurchaseRecord>>>> GetPurchaseItems()
        {
            var result = await _purchaseItemService.GetPurchaseItems();
            return Ok(result);
        }

        //[HttpPost("additem")]
        //public async Task<ActionResult<ServiceResponse<PurchaseRecord>>> AddPurchaseItem(PurchaseRecord purchaseRecord)
        //{
        //    var result = await _purchaseItemService.CreatePurchaseItem(purchaseRecord);
        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<PurchaseRecord>>>> AddPurchaseItems(List<PurchaseRecord> purchaseRecords)
        {
            var result = await _purchaseItemService.CreatePurchaseItems(purchaseRecords);
            return Ok(result);
        }
    }
}
