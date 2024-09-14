namespace National_Museum_2.Model
{
    public class Maintenance
    {
        public int Maintenance_Id { get; set; }
        public required int ArtObject_Id { get; set; }
        public required DateTime StarDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required string Description { get; set; }
        public required int Cost { get; set; }
        public required int Employee_Id { get; set; }
    }
}
