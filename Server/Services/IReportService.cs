namespace PHDSolutions.Server.Services
{
    public interface IReportService
    {
        Task<ServiceResponse<List<string>>> GetReport();
    }
}
