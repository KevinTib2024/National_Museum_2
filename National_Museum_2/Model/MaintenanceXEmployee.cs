using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class MaintenanceXEmployee
    {
        public int maintenanceXEmployee_Id {  get; set; }

        public int maitenance_Id { get; set; }
        public   Maintenance maitenance { get; set; }

        public int employee_Id { get; set; }
        public Employees employees { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;


    }
}
