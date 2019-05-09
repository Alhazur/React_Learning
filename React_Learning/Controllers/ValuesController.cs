using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace React_Learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet] // Get all
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "C#", "C++", "Python", "Basic", "VB", "Java" };
        }

        // GET api/values/5
        [HttpGet("{id}")] //Get One
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]  // Create
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")] //Edit  put 0 många fält/props // Patch = ett fölt/prop
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
