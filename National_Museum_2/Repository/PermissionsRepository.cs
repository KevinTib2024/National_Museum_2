﻿using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPermissionsRepository
    {
        Task<IEnumerable<Permissions>> GetAllPermissionsAsync();
        Task<Permissions> GetPermissionsByIdAsync(int id);
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

        public async Task CreatePermissionsAsync(Permissions permissions)
        {
            if (permissions == null)
                throw new ArgumentNullException(nameof(permissions));

            // Agregar el objeto al contexto
            _context.permissions.Add(permissions);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Permissions>> GetAllPermissionsAsync()
        {
            return await _context.permissions
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Permissions> GetPermissionsByIdAsync(int id)
        {
            return await _context.permissions
            .FirstOrDefaultAsync(s => s.permissionsId == id && !s.IsDeleted);
        }

        public async Task SoftDeletePermissionsAsync(int id)
        {
            var permissions = await _context.permissions.FindAsync(id);
            if (permissions != null)
            {
                permissions.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePermissionsAsync(Permissions permissions)
        {
            if (permissions == null)
                throw new ArgumentNullException(nameof(permissions));

            var existingPermissions = await _context.permissions.FindAsync(permissions.permissionsId);
            if (existingPermissions == null)
                throw new ArgumentException($"permissions with ID {permissions.permissionsId} not found");

            // Actualizar las propiedades del objeto existente
            existingPermissions.Permission = permissions.Permission;

            await _context.SaveChangesAsync();
        }
    }
}
