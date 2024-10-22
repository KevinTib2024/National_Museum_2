using National_Museum_2.DTO.UserType;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IUserTypeService
    {
        Task<IEnumerable<UserType>> GetAllUserTypeAsync();
        Task<UserType> GetUserTypeByIdAsync(int id);
        Task CreateUserTypeAsync(CreateUserTypeRequest userType);
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

        public async Task CreateUserTypeAsync(CreateUserTypeRequest userType)
        {
            await _userTypeRepository.CreateUserTypeAsync(userType);
        }

        public async Task<IEnumerable<UserType>> GetAllUserTypeAsync()
        {
            return await _userTypeRepository.GetAllUserTypeAsync();
        }

        public async Task<UserType> GetUserTypeByIdAsync(int id)
        {
            return await _userTypeRepository.GetUserTypeByIdAsync(id);
        }

        public async Task SoftDeleteUserTypeAsync(int id)
        {
            await _userTypeRepository.SoftDeleteUserTypeAsync(id);
        }

        public async Task UpdateUserTypeAsync(UserType userType)
        {
            await _userTypeRepository.UpdateUserTypeAsync(userType);
        }
    }
}
