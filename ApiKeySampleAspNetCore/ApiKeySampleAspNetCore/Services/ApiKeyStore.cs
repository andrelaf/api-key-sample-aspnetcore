using ApiKeySampleAspNetCore.Security;

namespace ApiKeySampleAspNetCore.Services
{

    internal class ApiKeyStore : IApiKeyStore
    {
        private static readonly Guid ReadWrite = Guid.Parse("00000000-0000-0000-0000-000000000000");
        private static readonly Guid ReadOnly = Guid.Parse("00000000-0000-0000-0000-000000000001");

        private readonly Dictionary<string, ApiKey> _keys = new()
        {
            { $"{ReadWrite}", new ApiKey($"{ReadWrite}", ReadWrite, "rw") },
            { $"{ReadOnly}", new ApiKey($"{ReadOnly}", ReadOnly, "r") },
        };

        public Task<ApiKey?> Get(string apiKey, CancellationToken cancellationToken)
        {
            _keys.TryGetValue(apiKey, out ApiKey? key);
            return Task.FromResult(key);
        }
    }
}
