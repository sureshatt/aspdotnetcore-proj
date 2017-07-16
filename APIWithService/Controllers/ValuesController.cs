using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWithService.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIWithService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        readonly IMyType _mytype;

        public ValuesController(IMyType mytype) {
            _mytype = mytype;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _mytype.Value };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _mytype.Value = value;
        }


    }
}
