using National_Museum_2.DTO.Gender;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IGenderService
    {
        Task<IEnumerable<Gender>> GetAllGenderAsync();
        Task<Gender> GetGenderByIdAsync(int id);
        Task CreateGenderAsync(CreateGenderRequest gender);
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

        public async Task CreateGenderAsync(CreateGenderRequest gender)
        {
            await _genderRepository.CreateGenderAsync(gender);
        }

        public async Task<IEnumerable<Gender>> GetAllGenderAsync()
        {
            return await _genderRepository.GetAllGenderAsync();
        }

        public async Task<Gender> GetGenderByIdAsync(int id)
        {
            return await _genderRepository.GetGenderByIdAsync(id);
        }

        public async Task SoftDeleteGenderAsync(int id)
        {
            await _genderRepository.SoftDeleteGenderAsync(id);
        }

        public async Task UpdateGenderAsync(Gender gender)
        {
            await _genderRepository.UpdateGenderAsync(gender);
        }
    }
}
