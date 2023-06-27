using ApiKeySampleAspNetCore.Security;

namespace ApiKeySampleAspNetCore.Services
{

    public interface IApiKeyStore
    {
        Task<ApiKey?> Get(string apiKey, CancellationToken cancellationToken);
    }
}
