using National_Museum_2.Model;
using National_Museum_2.Respositoy;

namespace National_Museum_2.Service
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetAllContactAsync();
        Task<Contact> GetContactByIdAsync(int id);
        Task CreateContactAsync(Contact contact);
        Task UpdateContactAsync(Contact contact);
        Task SoftDeleteContactAsync(int id);
    }

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task CreateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByIdAsync(int id)
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
