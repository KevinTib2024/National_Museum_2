namespace National_Museum_2.Model
{
    public class PermissionXUserType
    {
        public int permissionXUserTypeId { get; set; }

        public virtual required UserType userTypeId { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
