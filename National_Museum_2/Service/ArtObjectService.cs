using National_Museum_2.Model;

namespace National_Museum_2.Service
{
<<<<<<< HEAD:National_Museum_2/Service/EmployeeService.cs
    public interface EmployeeService
=======
    public class ArtObjectService
>>>>>>> KevinRamirez:National_Museum_2/Service/ArtObjectService.cs
    {
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesAsync(int id);
        Task CreateEmployeesAsync(Employees employees);
        Task UpdateEmployeesAsync(Employees employees);
        Task SoftDeleteEmployeesAsync(int id);
    }

}
