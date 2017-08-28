using AutoMapper;
using WebApplication.Infraestrutura.Profiles;

namespace WebApplication.Infraestrutura.Config
{
    public class AutoMapperConfig
    {
        public static IMapper CreateMapper()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<EmpregadoProfile>();
            });


            return config.CreateMapper();
        }
    }
}