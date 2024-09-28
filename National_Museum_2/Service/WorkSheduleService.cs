using National_Museum_2.Model;
using National_Museum_2.Repository;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IWorkSheduleService
    {
        Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync();
        Task<WorkShedule> GetWorkSheduleByAsync(int id);
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

        public Task CreateWorkSheduleAsync(WorkShedule workShedule)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkShedule> GetWorkSheduleByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteWorkSheduleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateWorkSheduleAsync(WorkShedule workShedule)
        {
            throw new NotImplementedException();
        }
    }
}
