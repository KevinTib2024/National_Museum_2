namespace National_Museum_2.Model
{
    public class ArtObject
    {
        public int ArtObject_Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Artist { get; set; }
        public required string CreationDate { get; set; }
        public required string Origin { get; set; }
        public required string Cost { get; set; }
        public required string Category_Id { get; set; }
        public required string State_Id { get; set; }
        public required string Exhibition_Id { get; set; }


    }
}
