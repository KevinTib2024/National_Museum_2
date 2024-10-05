using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface  IStateService
    {
        Task<IEnumerable<State>> GetAllStateAsync();
        Task<State> GetStateByIdAsync(int id);
        Task CreateStateAsync(State state);
        Task UpdateStateAsync(State state);
        Task SoftDeleteStateAsync(int id);
    }
    public class StateService : IStateService
    {
        public Task CreateStateAsync(State state)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> GetAllStateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<State> GetStateByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteStateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStateAsync(State state)
        {
            throw new NotImplementedException();
        }
    }
}
