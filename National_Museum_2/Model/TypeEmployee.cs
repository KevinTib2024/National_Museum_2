using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class TypeEmployee
    {
        public  int typeEmployeeId { get; set; }
        public required string typeEmployee { get; set; }
        public List<Employees> employees { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
