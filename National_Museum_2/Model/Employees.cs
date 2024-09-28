namespace National_Museum_2.Model
{
    public class Employees
    {
        public int employeeId { get; set; }
        public virtual required User user_Id { get; set; }
        public virtual required TypeEmployee typeEmployee_Id { get; set; }
        public virtual required WorkShedule workShedule_Id { get; set; }
        public required DateTime hiringDate { get; set; }
        public virtual required EmployeesXArtRoom employeesXArtRoom_Id { get; set; }
        public virtual required Maintenance maintenance_Id { get; set; }
       // public bool IsDeleted { get; set; } = false;

    }
}
