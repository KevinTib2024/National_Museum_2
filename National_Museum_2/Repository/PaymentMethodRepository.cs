using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IPaymentMethodRepository
    {
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByAsync(int id);
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

        public Task CreatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethod> GetPaymentMethodByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeletePaymentMethodAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
