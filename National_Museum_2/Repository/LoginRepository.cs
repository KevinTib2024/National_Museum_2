using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using National_Museum_2.Context;
using National_Museum_2.Model;


namespace National_Museum_2.Repository

{
    

    public interface ILoginRepository
        
    {
       
        Task <bool> AutenticationAsync(string email, string password);
    }
    public class LoginRepository : ILoginRepository
    {
        private readonly MuseumDbContext _context;
     
        private readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        private PasswordVerificationResult _result;

        public LoginRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task <bool> AutenticationAsync(string email, string password = "")
        {
            if (email == null ||password == null )
            {
                throw new ArgumentNullException();
            }
            var _user = await _context.user.FirstOrDefaultAsync(user => user.email == email);
            if (_user == null)
            {
                throw new ArgumentNullException(nameof(_user));
            }
            _result = _passwordHasher.VerifyHashedPassword(_user, _user.password, password);
            return _result == PasswordVerificationResult.Success;

        }

    }
}
