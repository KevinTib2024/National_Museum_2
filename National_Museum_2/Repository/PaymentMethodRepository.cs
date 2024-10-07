using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPaymentMethodRepository
    {
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(int id);
        Task CreatePaymentMethodAsync(PaymentMethod paymentMethod);
        Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod);
        Task SoftDeletePaymentMethodAsync(int id);
    }

    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly MuseumDbContext _context;

        public PaymentMethodRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            if (paymentMethod == null)
                throw new ArgumentNullException(nameof(paymentMethod));

            // Agregar el objeto al contexto
            _context.paymentMethods.Add(paymentMethod);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            return await _context.paymentMethods
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<PaymentMethod> GetPaymentMethodByIdAsync(int id)
        {
            return await _context.paymentMethods
            .FirstOrDefaultAsync(s => s.paymentMethodId == id && !s.IsDeleted);
        }

        public async Task SoftDeletePaymentMethodAsync(int id)
        {
            var paymentMethod = await _context.paymentMethods.FindAsync(id);
            if (paymentMethod != null)
            {
                paymentMethod.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            if (paymentMethod == null)
                throw new ArgumentNullException(nameof(paymentMethod));

            var existingPaymentMethod = await _context.paymentMethods.FindAsync(paymentMethod.paymentMethodId);
            if (existingPaymentMethod == null)
                throw new ArgumentException($"paymentMethod with ID {paymentMethod.paymentMethodId} not found");

            // Actualizar las propiedades del objeto existente
            existingPaymentMethod.paymentMethod = paymentMethod.paymentMethod;

            await _context.SaveChangesAsync();
        }
    }
}
