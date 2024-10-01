namespace National_Museum_2.Model
{
    public class Permissions
    {
        public required int permissionsId { get; set; }

        public virtual required PermissionXUserType PermissionXUserType_Id { get; set; }

        public required string Permission { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
