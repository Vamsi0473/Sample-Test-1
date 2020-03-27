using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PEAAPI.Controllers
{
    [Route("api/platts")]
    [ApiController]
    public class PlattsController : ControllerBase
    {
        string[] Datasets = new string[] { "AssessmentData", "EWindowData", "WRD", "CFlow", "Oil" };
        // GET api/values
        [HttpGet("datasets")]
        public ActionResult<IEnumerable<string>> GetDataSets()
        {
            return new string[] { "AssessmentData", "EWindowData","WRD","CFlow","Oil" };
        }

        // GET api/values/5
        [HttpGet("dataset/{id}")]
        public ActionResult<string> Get(int id)
        {
            return Datasets[id+1];
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
