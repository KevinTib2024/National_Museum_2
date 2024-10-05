namespace National_Museum_2.Model
{
    public class ArtObject
    {
        public int artObjectId { get; set; }

        public required string name { get; set; }
        public required string description { get; set; }
        public required string artist { get; set; }
        public required string creationDate { get; set; }
        public required string origin { get; set; }
        public required string cost { get; set; }
        public virtual required Category category_Id { get; set; }
        public virtual required State  state_Id { get; set; }
        public virtual required Exhibition exhibition_Id { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
