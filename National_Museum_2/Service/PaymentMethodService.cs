using National_Museum_2.DTO.PaymentMethod;
using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface IPaymentMethodService
    {
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(int id);
        Task CreatePaymentMethodAsync(CreatePaymentMetodRequest paymentMethod);
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

        public async Task CreatePaymentMethodAsync(CreatePaymentMetodRequest paymentMethod)
        {
            await _paymentMethodRepository.CreatePaymentMethodAsync(paymentMethod);
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            return await _paymentMethodRepository.GetAllPaymentMethodAsync();
        }

        public async Task<PaymentMethod> GetPaymentMethodByIdAsync(int id)
        {
            return await _paymentMethodRepository.GetPaymentMethodByIdAsync(id);
        }

        public async Task SoftDeletePaymentMethodAsync(int id)
        {
            await _paymentMethodRepository.SoftDeletePaymentMethodAsync(id);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            await _paymentMethodRepository.UpdatePaymentMethodAsync(paymentMethod);
        }
    }
}
