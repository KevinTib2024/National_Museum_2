using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository 
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllContactAsync();
        Task<Contact> GetContactByAsync(int id);
        Task CreateContactAsync(Contact contact);
        Task UpdateContactAsync(Contact contact);
        Task SoftDeleteContactAsync(int id);
    }

    public class ContactRepository : IContactRepository
    {
        private readonly MuseumDbContext _context;

        public ContactRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public Task CreateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteContactAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
