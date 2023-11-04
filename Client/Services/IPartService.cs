namespace PHDSolutions.Client.Services
{
    public interface IPartService
    {
        List<MaterialMaster> Parts { get; set; }

        Task GetParts();
    }
}
