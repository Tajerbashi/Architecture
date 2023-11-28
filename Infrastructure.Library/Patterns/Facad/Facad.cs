using Application.Library.Patterns.Facad;
using Application.Library.Repositories.SEC;

namespace Infrastructure.Library.Patterns.Facad
{
    public class Facad : IFacad
    {
        public IUserRepository UserRepository => throw new NotImplementedException();
    }
}
