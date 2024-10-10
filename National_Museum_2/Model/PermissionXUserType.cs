using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class PermissionXUserType
    {
        public int permissionXUserTypeId { get; set; }

        public virtual required UserType userType_Id { get; set; }

        public virtual required Permissions permissions_Id { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
