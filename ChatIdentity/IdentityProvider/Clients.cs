using System.Collections.Generic;
using IdentityServer4.Models;

namespace ChatIdentity
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClient",
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = new List<Secret> {new Secret("ChatSecret".Sha256())},
                    AllowedScopes = new List<string> { "openid", "profile", "api1.read" },
                    RedirectUris = new List<string> { "http://localhost:4200/auth-callback" },
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AlwaysSendClientClaims = true,
                    PostLogoutRedirectUris = new List<string> { "http://localhost:4200/" },
                }
            };
        }
    }
}
