using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IEmployeeRepository{
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesByIdAsync(int id);
        Task CreateEmployeesAsync(Employees employees);
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

        public async Task CreateEmployeesAsync(Employees employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            // Agregar el objeto al contexto
            _context.employee.Add(employee);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
        {
            return await _context.employee
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Employees> GetEmployeesByIdAsync(int id)
        {
            return await _context.employee
            .FirstOrDefaultAsync(s => s.employeeId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteEmployeesAsync(int id)
        {
            var employees = await _context.employee.FindAsync(id);
            if (employees != null)
            {
                employees.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateEmployeesAsync(Employees employees)
        {
            if (employees == null)
                throw new ArgumentNullException(nameof(employees));

            var existingEmployees = await _context.employee.FindAsync(employees.employeeId);
            if (existingEmployees == null)
                throw new ArgumentException($"employees with ID {employees.employeeId} not found");

            // Actualizar las propiedades del objeto existente
            existingEmployees.user_Id = employees.user_Id;
            existingEmployees.typeEmployee_Id = employees.typeEmployee_Id;
            existingEmployees.workShedule_Id = employees.workShedule_Id;
            existingEmployees.hiringDate = employees.hiringDate;
            existingEmployees.employeesXArtRoom_Id = employees.employeesXArtRoom_Id;
            existingEmployees.maintenance_Id = employees.maintenance_Id;

            await _context.SaveChangesAsync();
        }
    }
}
