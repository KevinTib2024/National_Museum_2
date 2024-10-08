using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class TicketType
    {
        public int ticketTypeId { get; set; }
        public required string ticketType { get; set; }
        public required float price { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
