namespace National_Museum_2.Model
{
    public class ArtRoom
    {
        public int artRoomId { get; set; } 

        public required string name { get ; set; }

        public required string description { get; set; }
        public virtual required Location location_Id{ get; set; }
        public required string numberExhibitions { get; set; }
        public virtual required Collection collection_Id { get; set; }
        public virtual required EmployeesXArtRoom employeesXArtRoom_Id { get; set; }

        


    }
}
