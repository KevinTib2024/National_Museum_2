using National_Museum_2.Model;

namespace National_Museum_2.Service
{
    public interface EmployeeService
    {
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesAsync(int id);
        Task CreateEmployeesAsync(Employees employees);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }

}
