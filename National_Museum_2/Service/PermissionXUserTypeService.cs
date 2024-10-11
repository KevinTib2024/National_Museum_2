using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IPermissionXUserTypeService
    {
        Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync();
        Task<PermissionXUserType> GetPermissionXUserTypeByIdAsync(int id);
        Task CreatePermissionXUserTypeAsync(PermissionXUserType user);
        Task UpdatePermissionXUserTypeAsync(PermissionXUserType user);
        Task SoftDeletePermissionXUserTypeAsync(int id);
        Task<bool> HasPermissionAsync(int userType_Id, int permissions_Id);
    }

    public class PermissionXUserTypeService : IPermissionXUserTypeService
    {
        private readonly IPermissionXUserTypeRepository _permissionXUserTypeRepository;

        public PermissionXUserTypeService(IPermissionXUserTypeRepository permissionXUserTypeRepository)
        {
            _permissionXUserTypeRepository = permissionXUserTypeRepository;
        }

        public async Task CreatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
        {
            await _permissionXUserTypeRepository.CreatePermissionXUserTypeAsync(permissionXUserType);
        }

        public async Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync()
        {
            return await _permissionXUserTypeRepository.GetAllPermissionXUserTypeAsync();
        }

        public async Task<PermissionXUserType> GetPermissionXUserTypeByIdAsync(int id)
        {
            return await _permissionXUserTypeRepository.GetPermissionXUserTypeByIdAsync(id);
        }

        public async Task SoftDeletePermissionXUserTypeAsync(int id)
        {
            await _permissionXUserTypeRepository.SoftDeletePermissionXUserTypeAsync(id);
        }

        public async Task UpdatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
        {
            await _permissionXUserTypeRepository.UpdatePermissionXUserTypeAsync(permissionXUserType);
        }

        public async Task<bool> HasPermissionAsync(int userType_Id, int permission_Id)
        {
            try
            {
                return await _permissionXUserTypeRepository.HasPermissionAsync(userType_Id, permission_Id);
            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}
