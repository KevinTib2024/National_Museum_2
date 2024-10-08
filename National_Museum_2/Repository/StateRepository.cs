using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetAllStateAsync();
        Task<State> GetStateByIdAsync(int id);
        Task CreateStateAsync(State state);
        Task UpdateStateAsync(State state);
        Task SoftDeleteStateAsync(int id);
    }
    public class StateRepository : IStateRepository
    {
        private readonly MuseumDbContext _context;

        public StateRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateStateAsync(State state)
        {
            if (state == null)
                throw new ArgumentNullException(nameof(state));

            // Agregar el objeto al contexto
            _context.state.Add(state);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<State>> GetAllStateAsync()
        {
            return await _context.state
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<State> GetStateByIdAsync(int id)
        {
            return await _context.state
             .FirstOrDefaultAsync(s => s.stateId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteStateAsync(int id)
        {
            var state = await _context.state.FindAsync(id);
            if (state != null)
            {
                state.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateStateAsync(State state)
        {
            if (state == null)
                throw new ArgumentNullException(nameof(state));

            var existingState = await _context.state.FindAsync(state.stateId);
            if (existingState == null)
                throw new ArgumentException($"state with ID {state.stateId} not found");

            // Actualizar las propiedades del objeto existente
            existingState.state = state.state;

            await _context.SaveChangesAsync();
        }
    }
}
