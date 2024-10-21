using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class WorkShedule
    {
        public required int workSheduleId { get; set; }
        public required string workShedule { get; set; }

        public List<Employees> employees { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
