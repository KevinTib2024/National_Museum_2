using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.IdentificationType;
using National_Museum_2.DTO.UserType;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IUserTypeRepository
    {
        Task<IEnumerable<GetUserTypeRequest>> GetAllUserTypeAsync();
        Task<GetUserTypeRequest> GetUserTypeByIdAsync(int id);
        Task CreateUserTypeAsync(CreateUserTypeRequest userType);
        Task UpdateUserTypeAsync(UpdateUserTypeRequest userType);
        Task SoftDeleteUserTypeAsync(int id);
    }

    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly MuseumDbContext _context;

        public UserTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserTypeAsync(CreateUserTypeRequest userType)
        {
            if (userType == null)
                throw new ArgumentNullException(nameof(userType));
            var _newuserType = new UserType
            {
                userType = userType.userType,
            };

            // Agregar el objeto al contexto
            _context.userType.Add(_newuserType);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetUserTypeRequest>> GetAllUserTypeAsync()
        {
            return await _context.userType
            .Where(s => !s.IsDeleted)
           .Select(s => new GetUserTypeRequest { userType = s.userType })
            .ToListAsync();
        }

        public async Task<GetUserTypeRequest> GetUserTypeByIdAsync(int id)
        {
            return await _context.userType
            .Where(s => s.userTypeId == id && !s.IsDeleted)
            .Select(s => new GetUserTypeRequest { userType= s.userType}).FirstOrDefaultAsync();

        }

        public async Task SoftDeleteUserTypeAsync(int id)
        {
            var userType = await _context.userType.FindAsync(id);
            if (userType != null)
            {
                userType.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateUserTypeAsync(UpdateUserTypeRequest userType)
        {
            if (userType == null)
                throw new ArgumentNullException(nameof(userType));

            var existingUserType = await _context.userType.FindAsync(userType.userTypeId);
            if (existingUserType == null)
                throw new ArgumentException($"userType with ID {userType.userTypeId} not found");

            // Actualizar las propiedades del objeto existente
            existingUserType.userType = String.IsNullOrEmpty(userType.userType)? existingUserType.userType : userType.userType;

            await _context.SaveChangesAsync();
        }
    }
}
