using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ILoginService
    {
        Task<bool> AutenticationAsync(string email, string password);
    }


    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<bool> AutenticationAsync(string email, string password)
        {
            return await _loginRepository.AutenticationAsync(email, password);
        }
    }
}

