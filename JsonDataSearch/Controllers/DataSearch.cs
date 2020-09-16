using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace JsonDataSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataSearch : ControllerBase
    {
        private IHostingEnvironment _env;
        public DataSearch(IHostingEnvironment env)
        {
            _env = env; 
        }

        // GET api/values
        //Calling html file 
        [HttpGet]
        [Produces("text/html")]
        public ActionResult<string> GetJsonData()
        {
            var webRoot = _env.WebRootPath;
            var fileContent = System.IO.File.ReadAllText(webRoot + "/SearchValue.html");
            return base.Content(fileContent, "text/html");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string name)
        {
            return "";
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
