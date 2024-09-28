using National_Museum_2.Context;
using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Repository
{
    public interface IWorkSheduleRepository
    {
        Task<IEnumerable<WorkShedule>> GetAllWorkSheduleAsync();
        Task<WorkShedule> GetWorkSheduleByAsync(int id);
        Task CreateWorkSheduleAsync(WorkShedule workShedule);
        Task UpdateWorkSheduleAsync(WorkShedule workShedule);
        Task SoftDeleteWorkSheduleAsync(int id);
    }

    public class WorkSheduleRepository : IWorkSheduleRepository
    {
        private readonly MuseumDbContext _context;

        public WorkSheduleRepository(MuseumDbContext context)
        {
            _context = context;
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
