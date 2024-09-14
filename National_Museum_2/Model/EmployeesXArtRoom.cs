namespace National_Museum_2.Model
{
    public class EmployeesXArtRoom
    {
        public int EmployeesXArtRoom_Id { get; set; }
        public required int Employee_Id { get; set; }
        public required int ArtRoom_Id { get; set; }
    }
}
