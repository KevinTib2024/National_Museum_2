namespace National_Museum_2.DTO.TypeEmployee
{
    public class ICreateTypeEmployeeRequest
    {
        string typeEmployee { get; set; }
    }
    public class CreateTypeEmployeeRequest : ICreateTypeEmployeeRequest
    {
        public string typeEmployee { get; set; }
    }
}
