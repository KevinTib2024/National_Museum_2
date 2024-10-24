namespace National_Museum_2.DTO.IdentificationType
{
    public interface IGetIdentificationTypeRequest
    {
        string Identification_Type { get; set; }
    }
    public class GetIdentificationTypeRequest : IGetIdentificationTypeRequest
    {
        public string Identification_Type { get; set; }
    }
}
