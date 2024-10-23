namespace National_Museum_2.DTO.Permissions
{
    public interface IUpdatePermissionsRequest
    {
        int permissionsId { get; set; }
        string? permission { get; set; }
    }
    public class UpdatePermissionsRequest : IUpdatePermissionsRequest
    {
        public string? permission { set; get; }
        public int permissionsId { get; set; }

    }
}


