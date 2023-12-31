﻿using Microsoft.AspNetCore.Authorization;

namespace ApiKeySampleAspNetCore.Authorization
{

    /// <summary>
    /// Our permissions are only Read/Write
    /// </summary>
    /// <param name="Permission"></param>

    public record PermissionRequirement(string Permission) : IAuthorizationRequirement
    {
    }
}
