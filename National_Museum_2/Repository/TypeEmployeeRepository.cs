using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Repository
{
    public interface ITypeEmployeeRepository
    {
        Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync();
        Task<TypeEmployee> GetTypeEmployeeByAsync(int id);
        Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee);
        Task UpdateTypeEmployeeAsync(TypeEmployee typeEmployee);
        Task SoftDeleteTypeEmployeeAsync(int id);
    }

    public class TypeEmployeeRepository : ITypeEmployeeRepository
    {
        private readonly MuseumDbContext _context;

        public TypeEmployeeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateTypeEmployeeAsync(TypeEmployee typeEmployee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeEmployee>> GetAllTypeEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TypeEmployee> GetTypeEmployeeByAsync(int id)
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
