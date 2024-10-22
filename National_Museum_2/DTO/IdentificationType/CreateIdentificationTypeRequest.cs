namespace National_Museum_2.DTO.IdentificationType
{
    public class ICreateIdentificationTypeRequest
    {
        string Identification_Type {  get; set; }
    }
    public class CreateIdentificationTypeRequest : ICreateIdentificationTypeRequest
    {
        public string Identification_Type { get; set; }
        
    }
}
