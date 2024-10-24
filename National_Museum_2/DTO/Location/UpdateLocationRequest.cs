namespace National_Museum_2.DTO.Location
{
    public class IUpdateLocationRequest
    {
        int location_Id { get; set; }
        string? name { get; set; }
    }
    public class UpdateLocationRequest : IUpdateLocationRequest
    {
        public int location_Id { get; set; }
        public string? name { get; set; }
    }

}
