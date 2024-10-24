using National_Museum_2.DTO.Permissions;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IPermissionsService
    {
        Task<IEnumerable<Permissions>> GetAllPermissionsAsync();
        Task<Permissions> GetPermissionsByIdAsync(int id);
        Task CreatePermissionsAsync(CreatePermissionsRequest permissions);
        Task UpdatePermissionsAsync(UpdatePermissionsRequest permissions);
        Task SoftDeletePermissionsAsync(int id);
    }

    public class PermissionsService : IPermissionsService
    {
        private readonly IPermissionsRepository _permissionsRepository;

        public PermissionsService(IPermissionsRepository permissionsRepository)
        {
            _permissionsRepository = permissionsRepository;
        }

        public async Task CreatePermissionsAsync(CreatePermissionsRequest permissions)
        {
            await _permissionsRepository.CreatePermissionsAsync(permissions);
        }

        public async Task<IEnumerable<Permissions>> GetAllPermissionsAsync()
        {
            return await _permissionsRepository.GetAllPermissionsAsync();
        }

        public async Task<Permissions> GetPermissionsByIdAsync(int id)
        {
            return await _permissionsRepository.GetPermissionsByIdAsync(id);
        }

        public async Task SoftDeletePermissionsAsync(int id)
        {
            await _permissionsRepository.SoftDeletePermissionsAsync(id);
        }

        public async Task UpdatePermissionsAsync(UpdatePermissionsRequest permissions)
        {
            await _permissionsRepository.UpdatePermissionsAsync(permissions);
        }
    }
}
