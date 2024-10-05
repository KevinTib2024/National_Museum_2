using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IGenderService
    {
        Task<IEnumerable<Gender>> GetAllGenderAsync();
        Task<Gender> GetGenderByIdAsync(int id);
        Task CreateGenderAsync(Gender gender);
        Task UpdateGenderAsync(Gender gender);
        Task SoftDeleteGenderAsync(int id);
    }

    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _genderRepository;

        public GenderService(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public Task CreateGenderAsync(Gender gender)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> GetAllGenderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetGenderByIdAsync(int id)
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
