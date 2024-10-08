using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class EmployeesXArtRoom
    {
        public int employeesXArtRoomId { get; set; }
        public required int employeeId { get; set; }
        public required int artRoomId { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
