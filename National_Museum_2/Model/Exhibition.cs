namespace National_Museum_2.Model
{
    public class Exhibition
    {
        public int Exhibition_Id { get; set; }

        public required string Name { get; set; }
        public required string Description{ get; set; }
        public required string ArtRoom_Id { get; set; }

    }
}
