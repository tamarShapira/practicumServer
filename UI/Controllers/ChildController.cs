using Microsoft.AspNetCore.Mvc;
using Repository;
using Services.Interfaces;
using Services.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChildController : ControllerBase
    {
        IChildService service;
        private readonly SqlDataSource context;
        public ChildController(IChildService _service,SqlDataSource _context)
        {
            service = _service;
            context= _context;
        }

        // GET: api/<ChildController>
        [HttpGet]
        public async Task<IEnumerable<ChildModel>> Get()
        {
            //var result=service.GetAll();
            //  return result;
            return await service.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChildModel> Get(int id)
        {
            return await service.GetByIdAsync(id);
            //return "value";
        }

        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel child)
        {
           return await service.AddAsync(child);
        }

        // PUT api/<ChildController>/5
        [HttpPut]
        public async Task Put(ChildModel child)
        {
            await service.UpdateAsync(child);
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task  Delete(int id)
        {
            await service.DeleteAsync(id);
            //if (context.Child == null)
            //{
            //    return NotFound();
            //}
            //var child = await context.Child.FindAsync(id);
            //if (child == null)
            //{
            //    return NotFound();
            //}

            //context.Child.Remove(child);
            //await context.SaveChangesAsync();

            //return NoContent();
        }
    }
}
