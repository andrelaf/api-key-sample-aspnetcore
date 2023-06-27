using Microsoft.AspNetCore.Authorization;

namespace ApiKeySampleAspNetCore.Filters
{
    public class PermissionReadAuthorize : AuthorizeAttribute
    {
        public PermissionReadAuthorize()
        {
            Policy = Constants.Permissions.Read;
        }

    }
}
