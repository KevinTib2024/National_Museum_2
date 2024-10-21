using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class UserType
    {
        public int userTypeId { get; set; }

        public required string userType { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

        public List<PermissionXUserType> permissionsXUserType { get; set; }
        public List<User> users  { get; set; }
    }
}
