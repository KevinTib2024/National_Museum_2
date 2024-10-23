using National_Museum_2.DTO.Gender;
using National_Museum_2.DTO.IdentificationType;
using National_Museum_2.DTO.UserType;

namespace National_Museum_2.DTO.User
{
    public interface IGetUserRequest
    {
        int userId { get; set; }
        int gender_Id { get; set; }
        int identificationType_Id { get; set; }
        int user_Type_Id { get; set; }

        string names { get; set; }
        string lastNames { get; set; }
        string identificationNumber { get; set; }
        string birthDate { get; set; }
        string email { get; set; }
        string password { get; set; }
        string contact { get; set; }
        IGetGenderRequest gender { get; set; }
        IGetIdentificationTypeRequest identificationType { get; set; }
        IGetUserTypeRequest userType { get; set; }


    }
    public class GetUserRequest : IGetUserRequest
    {
        public int userId { get; set; }
        public int gender_Id { get; set; }
        public int identificationType_Id { get; set; }
        public int user_Type_Id { get; set; }

        public string identificationNumber { get; set; }
        public string birthDate { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string lastNames { get; set; }
        public string names { get; set; }
       public IGetGenderRequest gender {  set; get; }
       public IGetIdentificationTypeRequest identificationType { get; set; }
       public IGetUserTypeRequest userType { get; set; }



    }

}
