using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IUserTypeService
    {
        Task<IEnumerable<UserType>> GetAllUserTypeAsync();
        Task<UserType> GetUserTypeByAsync(int id);
        Task CreateUserTypeAsync(UserType userType);
        Task UpdateUserTypeAsync(UserType userType);
        Task SoftDeleteUserTypeAsync(int id);
    }

    public class UserTypeService : IUserTypeService
    {
        private readonly IUserTypeRepository _userTypeRepository;

        public UserTypeService(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
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
