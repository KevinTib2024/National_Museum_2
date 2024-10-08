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

        public async Task CreateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
        {
            await _employeesXArtRoomRepository.CreateEmployeesXArtRoomAsync(employeesXArtRoom);
        }

        public async Task<IEnumerable<EmployeesXArtRoom>> GetAllEmployeesXArtRoomAsync()
        {
            return await _employeesXArtRoomRepository.GetAllEmployeesXArtRoomAsync();
        }

        public async Task<EmployeesXArtRoom> GetEmployeesXArtRoomByIdAsync(int id)
        {
            return await _employeesXArtRoomRepository.GetEmployeesXArtRoomByIdAsync(id);
        }

        public async Task SoftDeleteEmployeesXArtRoomAsync(int id)
        {
            await _employeesXArtRoomRepository.SoftDeleteEmployeesXArtRoomAsync(id);
        }

        public async Task UpdateEmployeesXArtRoomAsync(EmployeesXArtRoom employeesXArtRoom)
        {
            await _employeesXArtRoomRepository.UpdateEmployeesXArtRoomAsync(employeesXArtRoom);
        }
    }
}
