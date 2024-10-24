using National_Museum_2.DTO.State;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface  IStateService
    {
        Task<IEnumerable<State>> GetAllStateAsync();
        Task<State> GetStateByIdAsync(int id);
        Task CreateStateAsync(CreateStateRequest state);
        Task UpdateStateAsync(State state);
        Task SoftDeleteStateAsync(int id);
    }
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;

        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task CreateStateAsync(CreateStateRequest state)
        {
            await _stateRepository.CreateStateAsync(state);
        }

        public async Task<IEnumerable<State>> GetAllStateAsync()
        {
            return await _stateRepository.GetAllStateAsync();
        }

        public async Task<State> GetStateByIdAsync(int id)
        {
            return await _stateRepository.GetStateByIdAsync(id);
        }

        public async Task SoftDeleteStateAsync(int id)
        {
            await _stateRepository.SoftDeleteStateAsync(id);
        }

        public async Task UpdateStateAsync(State state)
        {
            await _stateRepository.UpdateStateAsync(state);
        }
    }
}
