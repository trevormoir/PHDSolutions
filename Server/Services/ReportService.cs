namespace PHDSolutions.Server.Services
{
    public class ReportService : IReportService
    {
        private readonly PHDSolutionsContext _context;

        public ReportService(PHDSolutionsContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<string>>> GetReport()
        {
            //var parts = await _context.MaterialMaster.ToListAsync();
            List<string> report = new List<string>();

            var projects = _context.PurchaseRecord.Select(p => p.projet).Distinct().Include("ProjectRecord.Description");
            report = projects.ToList();

            return new ServiceResponse<List<string>> { Data = report };
        }
    }
}