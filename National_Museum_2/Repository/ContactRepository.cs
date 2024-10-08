using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository 
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllContactAsync();
        Task<Contact> GetContactByIdAsync(int id);
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

        public async Task CreateContactAsync(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            // Agregar el objeto al contexto
            _context.contact.Add(contact);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contact>> GetAllContactAsync()
        {
            return await _context.contact
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _context.contact
            .FirstOrDefaultAsync(s => s.contactId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteContactAsync(int id)
        {
            var contact = await _context.contact.FindAsync(id);
            if (contact != null)
            {
                contact.IsDeleted = true;
                await _context.SaveChangesAsync();

            }
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            var existingContact = await _context.contact.FindAsync(contact.contactId);
            if (existingContact == null)
                throw new ArgumentException($"contact with ID {contact.contactId} not found");

            // Actualizar las propiedades del objeto existente
            existingContact.user_Id = contact.user_Id;
            existingContact.contactType = contact.contactType;

            await _context.SaveChangesAsync();
        }
    }
}
