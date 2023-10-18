using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.AutoMapper.Models;

namespace WebAPI.AutoMapper.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        //Adicionar o membro do Automapper na injeção de dependencia
        private readonly IMapper _mapper;
        public PeopleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(PersonInputModel input)
        {
            //Modelo de instância sem o automapper

            //var person = new Person(
            //    1,
            //    input.FirstName,
            //    input.LastName,
            //    input.BirthDate,
            //    input.MaritalStatus,
            //    input.PhoneNumber,
            //    input.FullAddress
            //    );

            //Modelo de instância com o automapper do PersonInputModel -> Person
            var person = _mapper.Map<Person>(input);  

            return Ok(input);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var person = new Person(
                id,
                "Nome",
                "Sobrenome",
                DateTime.Now,
                MaritalStatusEnum.Solteiro,
                "11987654321",
                "Endereço completo"
                );

            //Modelo de instância com o automapper do Person -> PersonViewModel
            var personViewModel = _mapper.Map<PersonViewModel>(person);

            return Ok(personViewModel);
        }
    }
}
