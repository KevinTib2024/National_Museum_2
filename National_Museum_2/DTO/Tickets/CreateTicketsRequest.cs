namespace National_Museum_2.DTO.Tickets
{
    public class ICreateTicketsRequest
    {
        int user_Id { get; set; }
        DateTime visitDate { get; set; }
        int ticketType_Id { get; set; }
        int paymentMethod_Id { get; set; }
        int employeeId { get; set; }

    }
    public class CreateTicketsRequest : ICreateTicketsRequest
    {
        public int user_Id { get; set; }
        public  DateTime visitDate { get; set; }
        public  int ticketType_Id { get; set; }
        public int paymentMethod_Id { get; set; }
        public int employeeId { get; set; }
    }
}
