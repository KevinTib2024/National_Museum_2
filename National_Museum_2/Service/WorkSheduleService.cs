using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IWorkSheduleService
    {
        Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync();
        Task<WorkShedule> GetWorkSheduleByIdAsync(int id);
        Task CreateWorkSheduleAsync(WorkShedule workShedule);
        Task UpdateWorkSheduleAsync(WorkShedule workShedule);
        Task SoftDeleteWorkSheduleAsync(int id);
    }

    public class WorkSheduleService : IWorkSheduleService
    {
        private readonly IWorkSheduleRepository _workSheduleRepository;

        public WorkSheduleService(IWorkSheduleRepository workSheduleRepository)
        {
            _workSheduleRepository = workSheduleRepository;
        }

        public async Task CreateWorkSheduleAsync(WorkShedule workShedule)
        {
            await _workSheduleRepository.CreateWorkSheduleAsync(workShedule);
        }

        public async Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync()
        {
            return await _workSheduleRepository.GetAllWorkSheduleAsync();
        }

        public async Task<WorkShedule> GetWorkSheduleByIdAsync(int id)
        {
            return await _workSheduleRepository.GetWorkSheduleByIdAsync(id);
        }

        public async Task SoftDeleteWorkSheduleAsync(int id)
        {
            await _workSheduleRepository.SoftDeleteWorkSheduleAsync(id);
        }

        public async Task UpdateWorkSheduleAsync(WorkShedule workShedule)
        {
            await _workSheduleRepository.UpdateWorkSheduleAsync(workShedule);
        }
    }
}
