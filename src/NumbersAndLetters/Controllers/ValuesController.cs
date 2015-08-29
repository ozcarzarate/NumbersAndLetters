using NumbersAndLetters.Domain;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace NumbersAndLetters.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{numberOfSmall}/{numberOfBig}")]
        public Game Get(int numberOfSmall, int numberOfBig)
        {
            var result = new Game
            {
                Bigs = new List<int> { 50, 20 },
                Smalls = new List<int> { 2, 5, 7, 1 },
                Sample = "(20 * 50) - (2 * 5 * 7) + 1"
            };

            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
