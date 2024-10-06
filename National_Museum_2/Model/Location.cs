namespace National_Museum_2.Model
{
    public class Location
    {
        public int locationId { get; set; }

        public required string name { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
