using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface IGenderRepository
    {
        Task<IEnumerable<Gender>> GetAllGenderAsync();
        Task<Gender> GetGenderByAsync(int id);
        Task CreateGenderAsync(Gender gender);
        Task UpdateGenderAsync(Gender gender);
        Task SoftDeleteGenderAsync(int id);
    }

    public class GenderRepository : IGenderRepository
    {
        private readonly MuseumDbContext _context;

        public GenderRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateGenderAsync(Gender gender)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> GetAllGenderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetGenderByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteGenderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGenderAsync(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
