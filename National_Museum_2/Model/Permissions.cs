using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Permissions
    {
        public required int permissionsId { get; set; }

        public required string Permission { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
