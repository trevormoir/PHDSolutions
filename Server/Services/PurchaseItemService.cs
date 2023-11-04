using PHDSolutions.Shared;

namespace PHDSolutions.Server.Services
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private readonly PHDSolutionsContext _context;

        public PurchaseItemService(PHDSolutionsContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<PurchaseRecord>>> GetPurchaseItems()
        {
            var purchaseItems = await _context.PurchaseRecord.ToListAsync();

            return new ServiceResponse<List<PurchaseRecord>> { Data = purchaseItems };
        }

        public async Task<ServiceResponse<PurchaseRecord>> GetPurchaseItem(string PONumber)
        {
            var purchaseItem = await _context.PurchaseRecord.FirstOrDefaultAsync(p => p.PONumber == PONumber);

            return new ServiceResponse<PurchaseRecord> { Data = purchaseItem };
        }

        public async Task<ServiceResponse<PurchaseRecord>> CreatePurchaseItem(PurchaseRecord purchaseRecord)
        {
            var dbPurchaseItem = await _context.PurchaseRecord.FindAsync(purchaseRecord.PONumber);
            if (dbPurchaseItem != null)
            {
                return new ServiceResponse<PurchaseRecord>
                {
                    Success = false,
                    Message = "Purchase Order already added."
                };
            }
            _context.PurchaseRecord.Add(purchaseRecord);
            await _context.SaveChangesAsync();
            return new ServiceResponse<PurchaseRecord> { Data = purchaseRecord };
        }

        public async Task<ServiceResponse<List<PurchaseRecord>>> CreatePurchaseItems(List<PurchaseRecord> purchaseRecords)
        {
            string returnMessage = string.Empty;

            try
            {
                foreach (var record in purchaseRecords)
                {
                    var dbPurchaseItem = await _context.PurchaseRecord.FirstOrDefaultAsync(r => r.PONumber == record.PONumber);
                    if (dbPurchaseItem != null)
                    {
                        returnMessage += "Purchase Order " + record.PONumber + " already added.";
                    }
                    else
                    {
                        _context.PurchaseRecord.Add(record);
                    }
                }
                await _context.SaveChangesAsync();
                return new ServiceResponse<List<PurchaseRecord>> { Data = purchaseRecords, Message = returnMessage };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ServiceResponse<List<PurchaseRecord>> { Message = returnMessage };
            }
        }
    }
}