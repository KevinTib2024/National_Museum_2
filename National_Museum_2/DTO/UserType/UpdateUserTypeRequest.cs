namespace National_Museum_2.DTO.UserType
{
    public interface IUpdateUserTypeRequest
    {
        int userTypeId { get; set; }
        string? userType { get; set; }
    }
        public class UpdateUserTypeRequest : IUpdateUserTypeRequest
        {
        public int userTypeId { get; set; }
            public string? userType { get; set; }
        }

}
