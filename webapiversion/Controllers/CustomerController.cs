using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapiversion.Controllers
{
    [RoutePrefix("api/v1/Customer")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult getcustomers()
        {

            return Ok("Customer get call CustomerController-V1");
        }
    }
}
