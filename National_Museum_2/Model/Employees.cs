using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Employees
    {
        public int employeeId { get; set; }
        public virtual required int user_Id { get; set; }
        public virtual User user { get; set; }

        public virtual required int typeEmployee_Id { get; set; }
        public virtual  TypeEmployee typeEmployee { get; set; }

        public virtual required int workShedule_Id { get; set; }
        public virtual  WorkShedule workShedule { get; set; }

        public required DateTime hiringDate { get; set; }
        public virtual required int employeesXArtRoom_Id { get; set; }
        public virtual EmployeesXArtRoom employeesXArtRoom { get; set; }

        public virtual required int  maintenance_Id { get; set; }
        public virtual  Maintenance maintenance { get; set; }


        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
