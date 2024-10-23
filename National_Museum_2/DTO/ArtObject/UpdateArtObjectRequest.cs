namespace National_Museum_2.DTO.ArtObject
{
    public interface IUpdateArtObjectRequest
    {
        int artObjectId {  get; set; }
        int? exhibition_Id { get; set; }
        int? category_Id { get; set; }
        int? state_Id { get; set; }

        string? name { get; set; }
        string? description { get; set; }
        string? artist { get; set; }
        string? creationDate { get; set; }
        string? origin { get; set; }
        string? cost { get; set; }
    }
    public class UpdateArtObjectRequest : IUpdateArtObjectRequest
    {
        public int artObjectId { get; set; }
        public int? exhibition_Id { get; set; }
        public int? category_Id { get; set; }
        public int? state_Id { get; set; }

        public string? name { get; set; }
        public string? description { get; set; }
        public string? artist { get; set; }
        public string? creationDate { get; set; }
        public string? origin { get; set; }
        public string? cost { get; set; }
    }

}
