using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IIdentificationTypeService
    {
        Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync();
        Task<IdentificationType> GetIdentificationTypeByIdAsync(int id);
        Task CreateIdentificationTypeAsync(IdentificationType identificationType);
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

        public Task CreateIdentificationTypeAsync(IdentificationType identificationType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentificationType>> GetAllIdentificationTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentificationType> GetIdentificationTypeByIdAsync(int id)
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
