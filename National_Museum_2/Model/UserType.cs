namespace National_Museum_2.Model
{
    public class UserType
    {
        public int userTypeId { get; set; }

        public required string userType { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
