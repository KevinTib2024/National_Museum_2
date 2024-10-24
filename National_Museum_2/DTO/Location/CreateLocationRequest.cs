namespace National_Museum_2.DTO.Location
{
    public class ICreateLocationRequest
    {
        string name {  get; set; }
        
    }
    public class CreateLocationRequest : ICreateLocationRequest
    {
        public string name { get; set; }
        
    }
}
