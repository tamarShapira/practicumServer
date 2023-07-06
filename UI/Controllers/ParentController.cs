using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;
using Services.Interfaces;
using Services.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
       readonly IParentService service;
        private readonly SqlDataSource context;

        public ParentController(IParentService _service, SqlDataSource _context )
        {
           context = _context;
           service = _service;
        }

        // GET: api/<ParentController>
        [HttpGet]
        public async Task<IEnumerable<ParentModel>> Get()
        {
            //var result=service.GetAll();
            //  return result;
            return await service.GetAllAsync();
        }

        // GET api/<ParentController>/5
        [HttpGet("{id}")]
        public async Task<ParentModel> Get(int id)
        {
            return await service.GetByIdAsync(id);
            //return "value";
        }

        // POST api/<ParentController>
        [HttpPost]
        public async Task<ParentModel> Post([FromBody] ParentModel parent)
        {
          return await service.AddAsync(parent);
        }

        // PUT api/<ParentController>/5
        [HttpPut ]
        public async Task Put(ParentModel parent)
        {
            await service.UpdateAsync(parent);
        }
        // DELETE api/<ParentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);


        }

    }
}
