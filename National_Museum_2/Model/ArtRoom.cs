namespace National_Museum_2.Model
{
    public class ArtRoom
    {
        public int ArtRoom_Id { get; set; } 

        public required string Name { get ; set; }

        public required string Description { get; set; }
        public required string Location_id{ get; set; }
        public required string NumberExhibitions { get; set; }
        public virtual required Collection collection_Id { get; set; }
        public virtual required EmployeesXArtRoom employeesXArtRoom_Id { get; set; }

        


    }
}
