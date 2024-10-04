using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ITypeEmployeeService
    {
        Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync();
        Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id);
        Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee);
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

        public Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TypeEmployee> GetTypeEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteTypeEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
