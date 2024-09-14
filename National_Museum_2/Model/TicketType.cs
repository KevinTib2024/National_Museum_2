namespace National_Museum_2.Model
{
    public class TicketType
    {
        public int TicketType_Id { get; set; }
        public required string Ticket_Type { get; set; }
        public required float price { get; set; }
    }
}
