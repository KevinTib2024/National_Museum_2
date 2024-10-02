using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Repository
{
    namespace National_Museum_2.Repository
    {
        public interface IEmployeesXArtRoomRepository
        {
            Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync();
            Task<Employees> GetEmployeesXArtRoomByAsync(int id);
            Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
            Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
            Task SoftDeleteEmployeesXArtRoomAsync(int id);
        }
        public class EmployeesXArtRoomRepository : IEmployeesXArtRoomRepository
        {
            private readonly MuseumDbContext _context;

            public EmployeesXArtRoomRepository(MuseumDbContext context)
            {
                _context = context;
            }

            public Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
            {
                throw new NotImplementedException();
            }

            public Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync()
            {
                throw new NotImplementedException();
            }

            public Task<Employees> GetEmployeesXArtRoomByAsync(int id)
            {
                throw new NotImplementedException();
            }

            public Task SoftDeleteEmployeesXArtRoomAsync(int id)
            {
                throw new NotImplementedException();
            }

            public Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
            {
                throw new NotImplementedException();
            }
        }
    }
}
