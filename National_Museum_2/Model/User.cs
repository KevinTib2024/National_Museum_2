namespace National_Museum_2.Model
{
    public class User
    {
        public int userId { get; set; }

        public virtual required UserType user_Type_Id { get; set; }

        public virtual required IdentificationType identificationType_Id { get; set; }

        public required string identificationNumber { get; set; }

        public required string names { get; set; }

        public required string lastNames { get; set; }

        public required string birthDate { get; set; }

        //public virtual ICollection<Contact> Contacts { get; set; } = new  List<Contact>();

        public required string contact { get; set; }

        public virtual required Gender gender_Id { get; set; }
    }
}
