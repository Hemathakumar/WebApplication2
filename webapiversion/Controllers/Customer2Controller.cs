using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapiversion.Controllers
{
    [RoutePrefix("api/v2/Customer")]
    public class Customer2Controller : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult getcustomers()
        {
            return Ok("Customer get call Customer2Controller-V2");
        }
    }
}
