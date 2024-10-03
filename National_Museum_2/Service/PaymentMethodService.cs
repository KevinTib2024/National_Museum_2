using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IPaymentMethodService
    {
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(int id);
        Task CreatePaymentMethodAsync(PaymentMethod paymentMethod);
        Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod);
        Task SoftDeletePaymentMethodAsync(int id);
    }

    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }

        public Task CreatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethod> GetPaymentMethodByIdAsync(int id)
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
