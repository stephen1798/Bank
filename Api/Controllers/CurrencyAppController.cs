using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyAppController : ControllerBase
    {
        private readonly DbCurrencyRepository _dbRepo;

        public CurrencyAppController()
        {
            _dbRepo = new DbCurrencyRepository();
        }
        // GET api/values
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/values/5
        [HttpGet]
        public ActionResult<NBPResponse> Get([FromQuery]string time)
        {
            var dt = DateTime.Parse(time);
          return new NBPResponse();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}