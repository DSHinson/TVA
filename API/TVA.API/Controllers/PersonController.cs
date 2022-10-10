using Microsoft.AspNetCore.Mvc;
using TVA.DAL.Repository.Interface;

namespace TVA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));   
        }

        [HttpGet]
        public Object GetPersonsWithPagination([FromQuery] int page,int pageSize, string? search = null)
        {
            return _personRepository.GetPersonWithPagination(page, pageSize, search);
        }
    }
}
