namespace National_Museum_2.DTO.PaymentMethod
{
    public class ICreatePaymentMetodRequest
    {
        string paymentMethod {  get; set; }
    }
    public class CreatePaymentMetodRequest : ICreatePaymentMetodRequest
    {
        public string paymentMethod {get; set;}
    }
}
