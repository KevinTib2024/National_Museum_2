using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IPermissionXUserTypeService
    {
        Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync();
        Task<PermissionXUserType> GetPermissionXUserTypeByAsync(int id);
        Task CreatePermissionXUserTypeAsync(PermissionXUserType user);
        Task UpdatePermissionXUserTypeAsync(PermissionXUserType user);
        Task SoftDeletePermissionXUserTypeAsync(int id);
    }

    public class PermissionXUserTypeService : IPermissionXUserTypeService
    {
        private readonly IPermissionXUserTypeRepository _permissionXUserTypeRepository;

        public PermissionXUserTypeService(IPermissionXUserTypeRepository permissionXUserTypeRepository)
        {
            _permissionXUserTypeRepository = permissionXUserTypeRepository;
        }

        public Task CreatePermissionXUserTypeAsync(PermissionXUserType user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PermissionXUserType> GetPermissionXUserTypeByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeletePermissionXUserTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePermissionXUserTypeAsync(PermissionXUserType user)
        {
            throw new NotImplementedException();
        }
    }
}
