namespace National_Museum_2.Model
{
    public class PaymentMethod
    {
        public int paymentMethodId { get; set; }
        public required string paymentMethod { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
