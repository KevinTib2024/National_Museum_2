namespace National_Museum_2.DTO.Employees
{
    public class ICreateEmployeesRequest
    {
        int user_Id { get; set; }
        int typeEmployee_Id { get; set; }
        int workShedule_Id { get; set; }
        DateTime hiringDate { get; set; }
        int maintenance_Id { get; set; }
    }
    public class CreateEmployeesRequest : ICreateEmployeesRequest
    {
        public int user_Id { get; set; }
        public int typeEmployee_Id { get; set; }
        public int workShedule_Id { get; set; }
        public DateTime hiringDate { get; set; }
        public int maintenance_Id { get; set; }
    }
}

