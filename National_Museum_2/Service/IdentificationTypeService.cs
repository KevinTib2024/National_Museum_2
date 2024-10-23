using National_Museum_2.DTO.IdentificationType;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IIdentificationTypeService
    {
        Task<IEnumerable<GetIdentificationTypeRequest>> GetAllIdentificationTypeAsync();
        Task<GetIdentificationTypeRequest> GetIdentificationTypeByIdAsync(int id);
        Task CreateIdentificationTypeAsync(CreateIdentificationTypeRequest identificationType);
        Task UpdateIdentificationTypeAsync(IdentificationType identificationType);
        Task SoftDeleteIdentificationTypeAsync(int id);
    }

    public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly IIdentificationTypeRepository _identificationTypeRepository;

        public IdentificationTypeService(IIdentificationTypeRepository identificationTypeRepository)
        {
            _identificationTypeRepository = identificationTypeRepository;
        }

        public async Task CreateIdentificationTypeAsync(CreateIdentificationTypeRequest identificationType)
        {
            await _identificationTypeRepository.CreateIdentificationTypeAsync(identificationType);
        }

        public async Task<IEnumerable<GetIdentificationTypeRequest>> GetAllIdentificationTypeAsync()
        {
            return await _identificationTypeRepository.GetAllIdentificationTypeAsync();
        }

        public async Task<GetIdentificationTypeRequest> GetIdentificationTypeByIdAsync(int id)
        {
            return await _identificationTypeRepository.GetIdentificationTypeByIdAsync(id);
        }

        public async Task SoftDeleteIdentificationTypeAsync(int id)
        {
            await _identificationTypeRepository.SoftDeleteIdentificationTypeAsync(id);
        }

        public async Task UpdateIdentificationTypeAsync(IdentificationType identificationType)
        {
            await _identificationTypeRepository.UpdateIdentificationTypeAsync(identificationType);
        }
    }
}
