using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenCvSharp;

namespace ocv_pl_web.Controllers
{
    [Produces("application/json")]
    [Route("api/VisionData")]
    public class VisionDataController : Controller
    {
        // GET: api/VisionData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var exception = "";
            try
            {
                Mat m = new Mat();
            }
            catch(Exception e)
            {
                exception = e.Message;
                exception += e.StackTrace;
                exception += e.InnerException;
            }
            return new string[] { exception, "value1", "value2" };
        }

        // GET: api/VisionData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/VisionData
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/VisionData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
