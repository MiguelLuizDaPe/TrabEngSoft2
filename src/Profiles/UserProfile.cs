using AutoMapper;
using Webapi.Entites;
using Webapi.Models;

namespace Webapi.Profiles;

public class UsuarioProfile : Profile{
    public UsuarioProfile(){
        CreateMap<UsuarioForCreateDto, Usuario>().ReverseMap();
    }
}
