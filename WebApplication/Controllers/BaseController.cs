using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{

    [Route("api/[controller]")]
    public class BaseController : Controller
    {

        protected readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        
        
    }
}