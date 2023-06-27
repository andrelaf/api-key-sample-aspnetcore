using ApiKeySampleAspNetCore.Security;
using System.Security.Claims;

namespace ApiKeySampleAspNetCore.Services
{

    public interface IClaimsProvider
    {
        IEnumerable<Claim> GetClaimsFor(ApiKey apiKey);
    }
}
