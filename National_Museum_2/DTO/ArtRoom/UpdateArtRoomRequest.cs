namespace National_Museum_2.DTO.ArtRoom
{
    public class  IUpdateArtRoomRequest
    {
        int artRoomId { get; set; }
        int location_Id { get; set; }
        int collection_Id { get; set; }

        string name { get; set; }
        string description { get; set; }
        string numberExhibitions { get; set; }
    }
    public class UpdateArtRoomRequest : IUpdateArtRoomRequest
    {
        public int artRoomId { get; set; }
        public int location_Id { get; set; }
        public int collection_Id { get; set; }

        public string? name { get; set; }
        public string? description { get; set; }
        public string? numberExhibitions { get; set; }
    }

}
