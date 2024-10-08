using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class TypeEmployee
    {
        public required int typeEmployeeId { get; set; }
        public required string typeEmployee { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
