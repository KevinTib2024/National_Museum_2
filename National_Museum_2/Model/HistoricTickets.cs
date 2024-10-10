using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class HistoricTickets
    {
        public int historicTicketId { get; set; }
        public required int ticket_Id { get; set; }
        public required int user_Id { get; set; }
        public required DateTime visitDate { get; set; }
        public required int ticketType_Id { get; set; }
        public required int paymentMethod_Id { get; set; }
        public required int employeeId { get; set; }
        public required int ticketXCollection_Id { get; set; }
        public required DateTime ModificationDate { get; set; }
        public required int ModicationBy { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
