using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesAsync(int id);
        Task CreateEmployeesAsync(Employees employees);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }

    public class EmployeesService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesService(IEmployeeRepository employeRepository)
        {
            _employeeRepository = employeRepository;
        }

        public Task CreateEmployeesAsync(Employees employees)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employees> GetEmployeesAsync(int id)
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
