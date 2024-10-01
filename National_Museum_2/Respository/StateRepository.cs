using National_Museum_2.Context;
using National_Museum_2.Model;
namespace National_Museum_2.Respository
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetAllStateAsync();
        Task<State> GetStateByAsync(int id);
        Task CreateStateAsync(State state);
        Task UpdateStateAsync(State State);
        Task SoftDeleteStateAsync(int id);
    }
    public class StateRepository : IStateRepository
    {
        public Task CreateStateAsync(State state)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> GetAllStateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<State> GetStateByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteStateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStateAsync(State State)
        {
            throw new NotImplementedException();
        }
    }
}