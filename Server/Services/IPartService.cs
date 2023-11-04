namespace PHDSolutions.Server.Services
{
    public interface IPartService
    {
        Task<ServiceResponse<List<MaterialMaster>>> GetParts();
        Task<ServiceResponse<MaterialMaster>> GetPart(string partNumber);
    }
}
