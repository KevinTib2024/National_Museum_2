namespace National_Museum_2.Model
{
    public class Tickets
    {
        public int ticketId { get; set; }
        public virtual required User userId { get; set; }
        public required DateTime visitDate { get; set; }
        public virtual required TicketType ticketTypeId { get; set; }
        public virtual required PaymentMethod paymentMethodId { get; set; }
        public required int employeeId { get; set; }
        public virtual required TicketXCollection ticketXCollectionId { get; set; }

    }
}
