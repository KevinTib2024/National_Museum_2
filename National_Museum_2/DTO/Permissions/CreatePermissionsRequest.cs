using National_Museum_2.DTO.Permissions;

namespace National_Museum_2.DTO.Permissions
{
    public class ICreatePermissionsRequest
    {
        string permission { get; set; }
    }
}
public class CreatePermissionsRequest : ICreatePermissionsRequest
{
    public string permission { set; get; }

}

