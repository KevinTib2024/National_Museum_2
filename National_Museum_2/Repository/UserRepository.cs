using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(int id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly MuseumDbContext _context;

        public UserRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateUserAsync(User User)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User User)
        {
            throw new NotImplementedException();
        }
    }
}
