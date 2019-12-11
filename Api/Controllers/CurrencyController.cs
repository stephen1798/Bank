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
    public class CurrencyController : ControllerBase
    {
        private readonly DbCurrencyRepository _dbRepo;

        public CurrencyController()
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
        public ActionResult<NBPResponse> Get([FromQuery]CurrencyRequestModel query)
        {
            var repo = new HttpCurrencyRpository();
            var resp = repo.GetExchangeRate(query);
            _dbRepo.SaveCurrencyRate(resp.rates.FirstOrDefault());
            return resp;
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