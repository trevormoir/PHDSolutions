namespace PHDSolutions.Server.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();
    }
}
