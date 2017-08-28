
using System.Collections.Generic;
using AutoMapper;
using Core.Domain;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class EmpregadosController : BaseController
    {
        private readonly IRepository _repository;

        public EmpregadosController(IMapper mapper,
                                   IRepository repository)
            :base(mapper)
        {

            _repository = repository;
        }

        
        [HttpGet]
        public IActionResult GetAll()
        {
            var empregados = _mapper.Map<ICollection<EmpregadoViewModel>>(_repository.GetAll());

            return new OkObjectResult(empregados);
        }
        

        [HttpPost]
        public IActionResult Salvar(EmpregadoViewModel empregadoViewModel)
        {
            if (ModelState.IsValid)
            {
                var empregado = _mapper.Map<Empregado>(empregadoViewModel);
                _repository.AddAsync(empregado);
                
                return new CreatedAtRouteResult("teste", _mapper.Map<EmpregadoViewModel>(empregado));

            }

            return BadRequest(ModelState);
        }
    }
}