namespace National_Museum_2.DTO.TicketType
{
    public class ICreateTicketTypeRequest
    {
        string ticketType { get; set; }
        float price { get; set; }
    }
    public class CreateTicketTypeRequest : ICreateTicketTypeRequest
    {
       public string ticketType { get; set; }
       public float price { get; set; }
    }
}
