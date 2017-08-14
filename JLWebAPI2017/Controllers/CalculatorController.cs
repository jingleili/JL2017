using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JLWebAPI2017.Controllers
{
    public class CalculatorController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [Route("api/add")]
        [HttpGet]
        //"http://localhost:52354/api/add?x=1&y=2"
        public int Sum(int x, int y)
        {
            return x + y;

        }

        [Route("api/subtract")]
        [HttpGet]
        //"http://localhost:52354/api/add?x=1&y=2"
        public HttpResponseMessage Substract(int x, int y)
        {
            return Request.CreateResponse(HttpStatusCode.OK,x-y);

        }
    }
}