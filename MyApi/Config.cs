using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Collections.Generic;

public static class Config
{
    public static IEnumerable<Client> Clients => new List<Client>
    {
        new Client
        {
            ClientId = "angular-spa",
            ClientName = "Angular SPA",
            AllowedGrantTypes = GrantTypes.Code,
            RequirePkce = true,
            RequireClientSecret = false,
            RedirectUris = { "http://localhost:4200/auth-callback" },
            PostLogoutRedirectUris = { "http://localhost:4200" },
            AllowedCorsOrigins = { "http://localhost:4200" },
            AllowedScopes = { "openid", "profile", "email", "api1" },
            AllowAccessTokensViaBrowser = true
        }
    };

    public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
    {
        new ApiScope("api1", "My API")
    };

    public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
    {
        new ApiResource("api1")
        {
            Scopes = { "api1" }
        }
    };

    public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
        new IdentityResources.Email()
    };
}
