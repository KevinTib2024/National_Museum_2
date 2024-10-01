namespace National_Museum_2.Model
{
    public class Gender
    {
        public int genderId { get; set; }

        public required string gender { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
