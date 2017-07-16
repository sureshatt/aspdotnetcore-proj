using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace my_first_api_proj.Controllers
{
    [Route("api/[controller]")]
    public class NamesController : Controller
    {
        List<string> names = new List<string>(){ "Alice", "Bob", "Eve", "Mallory", "Trent"};
        // GET api/names
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return names;
        }

        // GET api/names/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return names.ElementAt(id);
        }

        // POST api/names
        [HttpPost]
        public IEnumerable<string> Post([FromBody]string name)
        {
            names.Add(name);
            return names;
        }

        // PUT api/names/5
        [HttpPut("{id}")]
        public IEnumerable<string> Put(int id, [FromBody]string name)
        {
            names.Insert(id, name);
            return names;
        }

        // DELETE api/names/5
        [HttpDelete("{id}")]
        public IEnumerable<string> Delete(int id)
        {
            names.RemoveAt(id);
            return names;
        }
    }
}
