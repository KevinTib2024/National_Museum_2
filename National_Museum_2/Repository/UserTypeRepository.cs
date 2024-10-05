using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IUserTypeRepository
    {
        Task<IEnumerable<UserType>> GetAllUserTypeAsync();
        Task<UserType> GetUserTypeByAsync(int id);
        Task CreateUserTypeAsync(UserType userType);
        Task UpdateUserTypeAsync(UserType userType);
        Task SoftDeleteUserTypeAsync(int id);
    }

    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly MuseumDbContext _context;

        public UserTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateUserTypeAsync(UserType userType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserType>> GetAllUserTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserType> GetUserTypeByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUserTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserTypeAsync(UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
