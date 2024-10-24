namespace National_Museum_2.DTO.UserType
{
    public class ICreateUserTypeRequest
    {
        string userType { get; set; }
    }
    public class CreateUserTypeRequest : ICreateUserTypeRequest
    {
       public  string userType { get; set; }
    }

}
