namespace National_Museum_2.DTO.Employees
{
    public class IUpdateEmployeesRequest
    {
        int employeeId { get; set; }
        int user_Id { get; set; }
        int typeEmployee_Id { get; set; }
        int workShedule_Id { get; set; }
        DateTime? hiringDate { get; set; }
        int maintenance_Id { get; set; }
    }
    public class UpdateEmployeesRequest : IUpdateEmployeesRequest
    {
        public int employeeId { get; set; }
        public int user_Id { get; set; }
        public int typeEmployee_Id { get; set; }
        public int workShedule_Id { get; set; }
        public DateTime? hiringDate { get; set; }
        public int maintenance_Id { get; set; }
    }

}
