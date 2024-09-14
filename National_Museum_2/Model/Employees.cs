namespace National_Museum_2.Model
{
    public class Employees
    {
        public int Employee_Id { get; set; }
        public required int User_Id { get; set; }
        public required int TypeEmployee_Id { get; set; }
        public required int WorkShedule_Id { get; set; }
        public required DateTime HiringDate { get; set; }
    }
}
