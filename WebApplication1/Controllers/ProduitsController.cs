using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitsController : ControllerBase
    {
        private ApiDbContext _db;
        public ProduitsController(ApiDbContext db)
        {

            _db = db;

        }
        // GET: api/<ProduitsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Produitsss);
        }

        // GET api/<ProduitsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProduitsController>
        [HttpPost]
        public IActionResult Post([FromBody] Produits value)
        {
            try
            {

                _db.Produitsss.Add(value);
                _db.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProduitsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProduitsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
