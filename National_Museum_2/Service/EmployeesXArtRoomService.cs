using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IEmployeesXArtRoomService
    {
        Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync();
        Task<EmployeesXArtRoom> GetEmployeesXArtRoomByIdAsync(int id);
        Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
        Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom);
        Task SoftDeleteEmployeesXArtRoomAsync(int id);
    }

    public class EmployeesXArtRoomService : IEmployeesXArtRoomService
    {
        private readonly IEmployeesXArtRoomRepository _employeesXArtRoomRepository;

        public EmployeesXArtRoomService(IEmployeesXArtRoomRepository employeesXArtRoomRepository)
        {
            _employeesXArtRoomRepository = employeesXArtRoomRepository;
        }

        public Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeesXArtRoom> GetEmployeesXArtRoomByIdAsync(int id)
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
