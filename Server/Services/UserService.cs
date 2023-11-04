using System.Net;

namespace PHDSolutions.Server.Services
{
    public class UserService : IUserService
    {
        private readonly PHDSolutionsContext _context;

        public UserService(PHDSolutionsContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return new ServiceResponse<List<User>> { Data = users };
        }
    }
}