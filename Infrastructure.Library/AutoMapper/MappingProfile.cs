using Application.Library.Repositories.SEC.DTO;
using Application.Library.Repositories.SEC.View;
using AutoMapper;
using Domain.Library.Entities.SEC;

namespace Infrastructure.Library.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserView>().ReverseMap();
        }
    }
}
