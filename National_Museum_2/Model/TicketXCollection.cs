namespace National_Museum_2.Model
{
    public class TicketXCollection
    {
        public int ticketXCollectionId { get; set; }
        public required int Ticket_Id { get; set; }
        public virtual required Collection collection_Id{ get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
