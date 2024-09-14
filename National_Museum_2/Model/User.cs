namespace National_Museum_2.Model
{
    public class User
    {
        public int User_Id { get; set; }
        public required int UserType_Id { get; set; }
        public required int IdentificationType_Id { get; set; }
        public required int IdentificationNumber { get; set; }
        public required string Names { get; set; }
        public required string Lastname { get; set; }
        public required DateTime BirthDate { get; set; }
        public required int Contact_Id { get; set; }
        public required string Contact { get; set; }
        public required int Gender_Id { get; set; }
    }
}
