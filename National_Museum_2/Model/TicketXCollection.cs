using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class TicketXCollection
    {
        public int ticketXCollectionId { get; set; }
    
        public required int Ticket_Id { get; set; }
        public required Tickets Ticket { get; set; }

        public virtual required int collection_Id{ get; set; }
        public virtual Collection collection { get; set; }

        

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
