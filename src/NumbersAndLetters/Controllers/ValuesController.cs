using NumbersAndLetters.Domain;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using NumbersAndLetters.Domain.Interfaces;
using NumberAndLetters.Domain;

namespace NumbersAndLetters.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IGameGenerator _gameGenerator;

        //public ValuesController(IGameGenerator gameGenerator)
        //{
        //    _gameGenerator = gameGenerator;
        //}

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{numberOfSmalls}/{numberOfBigs}")]
        public Game Get(int numberOfSmalls, int numberOfBigs)
        {
            _gameGenerator = new GameGenerator();
            var result = _gameGenerator.Get(numberOfSmalls, numberOfBigs);

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
