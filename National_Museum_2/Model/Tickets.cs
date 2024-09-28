namespace National_Museum_2.Model
{
    public class Tickets
    {
        public int Ticket_Id { get; set; }
        public required int User_Id { get; set; }
        public required DateTime VisitDate { get; set; }
        public required int TicketType_Id { get; set; }
        public required int PaymentMethod_Id { get; set; }
        public required int Employee_Id { get; set; }
    }
}
