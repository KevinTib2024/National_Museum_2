using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface IEmployeeRepository{
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesByAsync(int id);
        Task CreateEmployeesAsync(Employees employee);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MuseumDbContext _context;

        public EmployeeRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateEmployeesAsync(Employees employee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employees> GetEmployeesByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteEmployeesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeesAsync(Employees employees)
        {
            throw new NotImplementedException();
        }
    }
}
