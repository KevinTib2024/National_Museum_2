namespace National_Museum_2.Model
{
    public class TicketType
    {
        public int ticketTypeId { get; set; }
        public required string ticketType { get; set; }
        public required float price { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
