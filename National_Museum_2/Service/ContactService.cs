using National_Museum_2.Model;
using National_Museum_2.Repository;

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

        public async Task CreateContactAsync(Contact contact)
        {
            await _contactRepository.CreateContactAsync(contact);
        }

        public async Task<IEnumerable<Contact>> GetAllContactAsync()
        {
            return await _contactRepository.GetAllContactAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _contactRepository.GetContactByIdAsync(id);
        }

        public async Task SoftDeleteContactAsync(int id)
        {
            await _contactRepository.SoftDeleteContactAsync(id);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            await _contactRepository.UpdateContactAsync(contact);
        }
    }
}
