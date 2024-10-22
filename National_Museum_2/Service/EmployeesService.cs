using National_Museum_2.DTO.Employees;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IEmployeesService
    {
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesByIdAsync(int id);
        Task CreateEmployeesAsync(CreateEmployeesRequest employees);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }

    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesService(IEmployeeRepository employeesRepository)
        {
            _employeeRepository = employeesRepository;
        }

        public async Task CreateEmployeesAsync(CreateEmployeesRequest employees)
        {
            await _employeeRepository.CreateEmployeesAsync(employees);
        }

        public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employees> GetEmployeesByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeesByIdAsync(id);
        }

        public async Task SoftDeleteEmployeesAsync(int id)
        {
            await _employeeRepository.SoftDeleteEmployeesAsync(id);
        }

        public async Task UpdateEmployeesAsync(Employees employees)
        {
            await _employeeRepository.UpdateEmployeesAsync(employees);
        }
    }
}
