namespace PHDSolutions.Server.Services
{
    public class PartService : IPartService
    {
        private readonly PHDSolutionsContext _context;

        public PartService(PHDSolutionsContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<MaterialMaster>>> GetParts()
        {
            var parts = await _context.MaterialMaster.ToListAsync();

            return new ServiceResponse<List<MaterialMaster>> { Data = parts };
        }

        public async Task<ServiceResponse<MaterialMaster>> GetPart(string partNumber)
        {
            var part = await _context.MaterialMaster.FirstOrDefaultAsync(p => p.PartNumber == partNumber);

            return new ServiceResponse<MaterialMaster> { Data = part };
        }
    }
}