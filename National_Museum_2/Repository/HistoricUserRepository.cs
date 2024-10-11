using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IHistoricUserRepository
    {
        Task<IEnumerable<HistoricUser>> GetAllHistoricUserAsync();
        Task<HistoricUser> GetHistoricUserByIdAsync(int id);
        Task CreateHistoricUserAsync(HistoricUser historicUser);
        Task UpdateHistoricUserAsync(HistoricUser historicUser);
        Task SoftDeleteHistoricUserAsync(int id);
    }

    public class HistoricUserRepository : IHistoricUserRepository
    {
        private readonly MuseumDbContext _context;

        public HistoricUserRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateHistoricUserAsync(HistoricUser historicUser)
        {
            if (historicUser == null)
                throw new ArgumentNullException(nameof(historicUser));

            // Agregar el objeto al contexto
            _context.historicUser.Add(historicUser);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HistoricUser>> GetAllHistoricUserAsync()
        {
            return await _context.historicUser
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<HistoricUser> GetHistoricUserByIdAsync(int id)
        {
            return await _context.historicUser
            .FirstOrDefaultAsync(s => s.historicUserId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteHistoricUserAsync(int id)
        {
            var historicUser = await _context.historicUser.FindAsync(id);
            if (historicUser != null)
            {
                historicUser.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateHistoricUserAsync(HistoricUser historicUser)
        {
            if (historicUser == null)
                throw new ArgumentNullException(nameof(historicUser));

            var existingHistoricUser = await _context.historicUser.FindAsync(historicUser.historicUserId);
            if (existingHistoricUser == null)
                throw new ArgumentException($"historicUser with ID {historicUser.historicUserId} not found");

            // Actualizar las propiedades del objeto existente
            existingHistoricUser.user_Id = historicUser.user_Id;
            existingHistoricUser.user_Type_Id = historicUser.user_Type_Id;
            existingHistoricUser.identificationType_Id = historicUser.identificationType_Id;
            existingHistoricUser.identificationNumber = historicUser.identificationNumber;
            existingHistoricUser.names = historicUser.names;
            existingHistoricUser.lastNames = historicUser.lastNames;
            existingHistoricUser.birthDate = historicUser.birthDate;
            existingHistoricUser.contact = historicUser.contact;
            existingHistoricUser.gender_Id = historicUser.gender_Id;

            await _context.SaveChangesAsync();
        }
    }
}
