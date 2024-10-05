using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPermissionXUserTypeRepository
    {
        Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync();
        Task<PermissionXUserType> GetPermissionXUserTypeByAsync(int id);
        Task CreatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType);
        Task UpdatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType);
        Task SoftDeletePermissionXUserTypeAsync(int id);
    }

    public class PermissionXUserTypeRepository : IPermissionXUserTypeRepository
    {
        private readonly MuseumDbContext _context;

        public PermissionXUserTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
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

        public Task UpdatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
        {
            throw new NotImplementedException();
        }
    }
}
