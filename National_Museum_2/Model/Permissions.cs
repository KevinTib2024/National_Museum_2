using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Permissions
    {
        public  int permissionsId { get; set; }

        public required string permission { get; set; }

        public List<PermissionXUserType> permissionXUserTypes { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
