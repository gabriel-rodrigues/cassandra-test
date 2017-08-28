using AutoMapper;
using Core.Domain;
using WebApplication.Models;

namespace WebApplication.Infraestrutura.Profiles
{
    public class EmpregadoProfile : Profile
    {
        public EmpregadoProfile()
        {
            CreateMap<Empregado, EmpregadoViewModel>()
                .ReverseMap();
        }
    }
}