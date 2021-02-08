using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Test;

namespace ChatIdentity
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser> {
            new TestUser {
                SubjectId = "00000000-0000-0000-0000-000000000001",
                Username = "user11",
                Password = "user11",
                Claims = new List<Claim> {
                    new Claim(JwtClaimTypes.Email, "user11@gmail.com"),
                    new Claim(JwtClaimTypes.Role, "admin")
                }
            },
            new TestUser {
                SubjectId = "00000000-0000-0000-0000-000000000002",
                Username = "user22",
                Password = "user22",
                Claims = new List<Claim> {
                    new Claim(JwtClaimTypes.Email, "user22@gmail.com"),
                    new Claim(JwtClaimTypes.Role, "admin")
                }
            }
        };
        }
    }
}
