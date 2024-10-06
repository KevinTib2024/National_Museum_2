namespace National_Museum_2.Model
{
    public class Exhibition
    {
        public int exhibitionId { get; set; }

        public required string name { get; set; }
        public required string description{ get; set; }
        public virtual required ArtRoom artRoom_Id { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
