using National_Museum_2.DTO.ArtObject;

namespace National_Museum_2.DTO.ArtRoom
{
    public interface ICreateArtRoomRequest
    {
        int location_Id { get; set; }
        int collection_Id { get; set; }

        string name { get; set; }
        string description { get; set; }
        string numberExhibitions { get; set; }
    }
    public class CreateArtRoomRequest : ICreateArtRoomRequest
    {
        public int location_Id { get; set; }
        public int collection_Id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string numberExhibitions { get; set; }
    }
}
