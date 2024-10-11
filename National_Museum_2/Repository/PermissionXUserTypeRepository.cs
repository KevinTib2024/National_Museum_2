using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPermissionXUserTypeRepository
    {
        Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync();
        Task<PermissionXUserType> GetPermissionXUserTypeByIdAsync(int id);
        Task CreatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType);
        Task UpdatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType);
        Task SoftDeletePermissionXUserTypeAsync(int id);
        Task<bool> HasPermissionAsync(int userType_Id, int permissionsId);
    }

    public class PermissionXUserTypeRepository : IPermissionXUserTypeRepository
    {
        private readonly MuseumDbContext _context;

        public PermissionXUserTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
        {
            if (permissionXUserType == null)
                throw new ArgumentNullException(nameof(permissionXUserType));

            // Agregar el objeto al contexto
            _context.permissionXUserType.Add(permissionXUserType);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PermissionXUserType>> GetAllPermissionXUserTypeAsync()
        {
            return await _context.permissionXUserType
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<PermissionXUserType> GetPermissionXUserTypeByIdAsync(int id)
        {
            return await _context.permissionXUserType
            .FirstOrDefaultAsync(s => s.permissionXUserTypeId == id && !s.IsDeleted);
        }

        public async Task SoftDeletePermissionXUserTypeAsync(int id)
        {
            var permissionXUserType = await _context.permissionXUserType.FindAsync(id);
            if (permissionXUserType != null)
            {
                permissionXUserType.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePermissionXUserTypeAsync(PermissionXUserType permissionXUserType)
        {
            if (permissionXUserType == null)
                throw new ArgumentNullException(nameof(permissionXUserType));

            var existingPermissionXUserType = await _context.permissionXUserType.FindAsync(permissionXUserType.permissionXUserTypeId);
            if (existingPermissionXUserType == null)
                throw new ArgumentException($"permissionXUserType with ID {permissionXUserType.permissionXUserTypeId} not found");

            // Actualizar las propiedades del objeto existente
            existingPermissionXUserType.userType_Id = permissionXUserType.userType_Id;
            existingPermissionXUserType.permissions_Id = permissionXUserType.permissions_Id;

            await _context.SaveChangesAsync();
        }

        public async Task<bool> HasPermissionAsync(int userType_Id, int permissionsId)
        {
            var permission = await _context.permissionXUserType
            .Where(p => p.userType_Id.userTypeId == userType_Id && p.permissions_Id.permissionsId == permissionsId && !p.IsDeleted)
            .FirstOrDefaultAsync();

            return permission != null ? true : false;
        }
    }
}
