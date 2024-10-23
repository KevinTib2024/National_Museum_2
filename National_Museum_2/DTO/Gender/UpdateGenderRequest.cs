namespace National_Museum_2.DTO.Gender
{
    public interface IUpdateGenderRequest
    {

        int genderId { get; set; }
        string? gender { get; set; }
    }
    public class UpdateGenderRequest : IUpdateGenderRequest
    {
        public int genderId { get; set; }
        public string? gender { get; set; }
    }
}
