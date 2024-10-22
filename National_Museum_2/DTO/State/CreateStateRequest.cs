namespace National_Museum_2.DTO.State
{
    public class ICreateStateRequest
    {
        string state { get; set; }
    }
    public class CreateStateRequest : ICreateStateRequest
    {
        public string state { get; set; }
    }
}
