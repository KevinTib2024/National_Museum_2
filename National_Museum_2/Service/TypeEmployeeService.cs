using National_Museum_2.DTO.TypeEmployee;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITypeEmployeeService
    {
        Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync();
        Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id);
        Task CreateTypeEmployeeAsync(CreateTypeEmployeeRequest typeEmployee);
        Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee);
        Task SoftDeleteTypeEmployeeAsync(int id);
    }

    public class TypeEmployeeService : ITypeEmployeeService
    {
        private readonly ITypeEmployeeRepository _typeEmployeeRepository;

        public TypeEmployeeService(ITypeEmployeeRepository typeEmployeeRepository)
        {
            _typeEmployeeRepository = typeEmployeeRepository;
        }

        public async Task CreateTypeEmployeeAsync(CreateTypeEmployeeRequest typeEmployee)
        {
            await _typeEmployeeRepository.CreateTypeEmployeeAsync(typeEmployee);
        }

        public async Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync()
        {
            return await _typeEmployeeRepository.GetAllTypeEmployeeAsync();
        }

        public async Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id)
        {
            return await _typeEmployeeRepository.GetTypeEmployeeByIdAsync(id);
        }

        public async Task SoftDeleteTypeEmployeeAsync(int id)
        {
            await _typeEmployeeRepository.SoftDeleteTypeEmployeeAsync(id);
        }

        public async Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            await _typeEmployeeRepository.UpdateTypeEmployeeAsync(typeEmployee);
        }
    }
}
