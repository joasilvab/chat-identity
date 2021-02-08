using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace ChatIdentity.IdentityProvider
{
    public class ProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            await Task.Run(() => { });
            if (context.Subject.Identity.Name != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("username", context.Subject.Identity.Name)
                };
                context.IssuedClaims.AddRange(claims);
            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            await Task.Run(() => { });
            context.IsActive = true;
        }
    }
}
