using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class PaymentMethod
    {
        public int paymentMethodId { get; set; }
        public required string paymentMethod { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
