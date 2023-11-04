namespace PHDSolutions.Client.Services
{
    public interface IUserService
    {
        List<User> Users { get; set; }

        Task GetUsers();
    }
}
