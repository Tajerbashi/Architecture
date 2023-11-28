using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.AspNetCore.Mvc.Formatters;
using OpenId.Identity.Server.Models;
using System.Security.Claims;

namespace OpenId.Identity.Server.Resources.Models
{
    public class Configs
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "sdfsdvsdvsdv",
                    Username="Tajerbashi",
                    Password="1qaz!QAZ",
                    Claims = new List<Claim>
                    {
                        new Claim("Key","123456"),
                        new Claim("Role","ADMIN"),
                        new Claim("Name","Tajer"),
                    }
                },
                new TestUser
                {
                    SubjectId = "dsvdvsdv-sdvsdv-sdvsvd-sdvsdv",
                    Username = "AliKarimi",
                    Password = "147qaz"
                }
            };
        }
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource> 
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResources.Email(),
            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {

            };
        }
    }
}
