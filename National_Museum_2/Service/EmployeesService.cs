using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IEmployeesService
    {
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesByIdAsync(int id);
        Task CreateEmployeesAsync(Employees employees);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }

    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeeRepository _contactEmployees;

        public EmployeesService(IEmployeeRepository employeesRepository)
        {
            _contactEmployees = employeesRepository;
        }

        public Task CreateEmployeesAsync(Employees employees)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employees> GetEmployeesByIdAsync(int id)
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
