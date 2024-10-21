namespace National_Museum_2.DTO.Gender
{
    public interface ICreateGenderRequest
    {
        string gender { get; set; }
    }
    public class CreateGenderRequest : ICreateGenderRequest
    {
        public string gender { get; set; }
    }
}
