using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.DTO.Employees;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IEmployeeRepository{
        Task<IEnumerable<Employees>> GetAllEmployeesAsync();
        Task<Employees> GetEmployeesByIdAsync(int id);
        Task CreateEmployeesAsync(CreateEmployeesRequest employees);
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

        public async Task CreateEmployeesAsync(CreateEmployeesRequest employee)
        {
            var _user_Id = await _context.user.FindAsync(employee.user_Id);
            var _typeEmployee_Id = await _context.typeEmployee.FindAsync(employee.typeEmployee_Id);
            var _workShedule_Id = await _context.workShedule.FindAsync(employee.workShedule_Id);
            var _maintenance_Id = await _context.maintenance.FindAsync(employee.maintenance_Id);
            if (_user_Id == null)
            {
                throw new Exception("No se encontro id del usuario");
            }

            if (_typeEmployee_Id == null)
            {
                throw new Exception("No se encontro tipo de empleado");
            }
            if (_workShedule_Id == null)
            {
                throw new Exception("No se encontro horario de trabajo");
            }
            if (_maintenance_Id == null)
            {
                throw new Exception("No se encontro mantenimiento");
            }
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            var _newemployee = new Employees 
            {
                user_Id = employee.user_Id,
                typeEmployee_Id = employee.typeEmployee_Id,
                workShedule_Id = employee.workShedule_Id,
                maintenance_Id = employee.maintenance_Id,
                hiringDate = employee.hiringDate,

            };

            // Agregar el objeto al contexto
            _context.employee.Add(_newemployee);

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
            existingEmployees.maintenance_Id = employees.maintenance_Id;

            await _context.SaveChangesAsync();
        }
    }
}
