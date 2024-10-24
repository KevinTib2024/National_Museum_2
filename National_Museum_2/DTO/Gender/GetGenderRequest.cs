namespace National_Museum_2.DTO.Gender
{
    public  interface IGetGenderRequest
    {
        int genderId { get; set; }
        string gender { get; set; }
    }
    public class GetGenderRequest : IGetGenderRequest
    {
        public int genderId { get; set; }
        public string gender { get; set; }
    }

}
