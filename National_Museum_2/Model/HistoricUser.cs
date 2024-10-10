using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class HistoricUser
    {
        public int historicUserId { get; set; }
        public int user_Id { get; set; }
        public required int user_Type_Id { get; set; }
        public required int identificationType_Id { get; set; }
        public required string identificationNumber { get; set; }
        public required string names { get; set; }
        public required string lastNames { get; set; }
        public required string birthDate { get; set; }
        public required string contact { get; set; }
        public required int gender_Id { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public required DateTime ModificationDate { get; set; }
        public required int ModicationBy { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
