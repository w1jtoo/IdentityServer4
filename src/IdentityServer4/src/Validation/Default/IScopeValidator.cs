using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServer4.Validation
{
    public interface IScopeValidator
    {
        bool ValidateRequiredScopes(IEnumerable<string> consentedScopes);
        void SetConsentedScopes(IEnumerable<string> consentedScopes);
        bool IsResponseTypeValid(string responseType);
        Task<bool> AreScopesAllowedAsync(Client client, IEnumerable<string> requestedScopes);
        Task<bool> AreScopesValidAsync(IEnumerable<string> requestedScopes, bool filterIdentityScopes = false);
        bool ContainsOpenIdScopes { get; }
        bool ContainsApiResourceScopes { get; }
        bool ContainsOfflineAccessScope { get; }
        Resources RequestedResources { get; set; }
        Resources GrantedResources { get; set; }
    }
}