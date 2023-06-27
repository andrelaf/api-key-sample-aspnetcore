using Microsoft.AspNetCore.Authorization;

namespace ApiKeySampleAspNetCore.Filters
{

    public class PermissionWriteAuthorize : AuthorizeAttribute
    {
        public PermissionWriteAuthorize()
        {
            Policy = Constants.Permissions.Write;
        }
    }
}
