using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class User
    {
        public int userId { get; set; }

        public virtual  UserType user_Type { get; set; }
        public virtual required int  user_Type_Id { get; set; }


        public virtual  IdentificationType identificationType { get; set; }
        public virtual required int identificationType_Id { get; set; }

        public required string identificationNumber { get; set; }

        public required string names { get; set; }

        public required string lastNames { get; set; }

        public required string birthDate { get; set; }

        public required string contact { get; set; }

        public virtual  Gender gender { get; set; }
        public virtual required int gender_Id { get; set; }


        public required string email { get; set; }

        public required string password { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
