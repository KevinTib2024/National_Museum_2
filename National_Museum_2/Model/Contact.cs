namespace National_Museum_2.Model
{
    public class Contact
    {
        public required int contactId { get; set; }

        public virtual required User userId { get; set; }

       // public virtual required User User { get; set; }

        public required string contactType { get; set; }
    }
}
