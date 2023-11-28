using OpenId.Identity.Server.Models;

namespace OpenId.Identity.Server.ContextData
{
    public static class DatabaseContext
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel{ ID=1,Username="AA",Password="AaAa",Email="A@mail.com",Guid=new Guid(),Name="A"},
            new UserModel{ ID=2,Username="BB",Password="BbBb",Email="B@mail.com",Guid=new Guid(),Name="B"},
            new UserModel{ ID=3,Username="CC",Password="CcCc",Email="C@mail.com",Guid=new Guid(),Name="C"},
            new UserModel{ ID=4,Username="DD",Password="DdDd",Email="D@mail.com",Guid=new Guid(),Name="D"},
            new UserModel{ ID=5,Username="EE",Password="EeEe",Email="E@mail.com",Guid=new Guid(),Name="E"},
            new UserModel{ ID=6,Username="FF",Password="FfFf",Email="F@mail.com",Guid=new Guid(),Name="F"},
        };
    }
}
