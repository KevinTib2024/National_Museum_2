using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IIdentificationTypeRepository
    {
        Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync();
        Task<IdentificationType> GetIdentificationTypeByAsync(int id);
        Task CreateIdentificationTypeAsync(IdentificationType identificationType);
        Task UpdateIdentificationTypeAsync(IdentificationType identificationType);
        Task SoftDeleteIdentificationTypeAsync(int id);
    }

    public class IdentificationTypeRepository : IIdentificationTypeRepository
    {
        private readonly MuseumDbContext _context;

        public IdentificationTypeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateIdentificationTypeAsync(IdentificationType identificationType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentificationType> GetIdentificationTypeByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteIdentificationTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIdentificationTypeAsync(IdentificationType identificationType)
        {
            throw new NotImplementedException();
        }
    }
}
