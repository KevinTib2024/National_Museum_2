
using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{

    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(int id);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
