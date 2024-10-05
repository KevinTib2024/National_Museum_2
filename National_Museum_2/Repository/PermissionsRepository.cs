using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPermissionsRepository
    {
        Task<IEnumerable<Permissions>> GetAllPermissionsAsync();
        Task<Permissions> GetPermissionsByAsync(int id);
        Task CreatePermissionsAsync(Permissions permissions);
        Task UpdatePermissionsAsync(Permissions permissions);
        Task SoftDeletePermissionsAsync(int id);
    }

    public class PermissionsRepository : IPermissionsRepository
    {
        private readonly MuseumDbContext _context;

        public PermissionsRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreatePermissionsAsync(Permissions permissions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Permissions>> GetAllPermissionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Permissions> GetPermissionsByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeletePermissionsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePermissionsAsync(Permissions permissions)
        {
            throw new NotImplementedException();
        }
    }
}
