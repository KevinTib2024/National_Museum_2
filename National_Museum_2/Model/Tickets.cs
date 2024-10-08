using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Tickets
    {
        public int ticketId { get; set; }
        public virtual required User user_Id { get; set; }
        public required DateTime visitDate { get; set; }
        public virtual required TicketType ticketType_Id { get; set; }
        public virtual required PaymentMethod paymentMethod_Id { get; set; }
        public required int employeeId { get; set; }
        public virtual required TicketXCollection ticketXCollection_Id { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
