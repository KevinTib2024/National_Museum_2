using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task CreateUserAsync(RequestUser user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(int id);
        Task<bool> ValidateUserAsync(string email, string password);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Crear un nuevo usuario, delega la responsabilidad al repositorio
        public async Task CreateUserAsync(RequestUser user)
        {
            await _userRepository.CreateUserAsync(user);
        }

        // Obtener todos los usuarios no eliminados
        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _userRepository.GetAllUserAsync();
        }

        // Obtener un usuario por ID
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        // Eliminar un usuario de manera lógica (Soft Delete)
        public async Task SoftDeleteUserAsync(int id)
        {
            await _userRepository.SoftDeleteUserAsync(id);
        }

        // Actualizar un usuario, incluidas sus credenciales
        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }

        // Validar las credenciales de un usuario
        public async Task<bool> ValidateUserAsync(string email, string password)
        {
            try
            {
                return await _userRepository.ValidateUserAsync(email, password);
            }
            catch (Exception e)
            {
                // Puedes agregar un registro de log aquí para guardar la excepción
                Console.WriteLine($"Error en la validación de usuario: {e.Message}");
                throw;
            }
        }
    }
}
