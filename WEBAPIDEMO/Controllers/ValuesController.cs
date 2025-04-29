using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIDEMO.Models;


namespace WEBAPIDEMO.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
       
      
        public IEnumerable<Employee> Get()
        {
            localDBEntities1 localDBEntities1 = new localDBEntities1();

            return localDBEntities1.Employees.ToList() ;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] Employee emp)
        {
           
            
        }
        public void Post([FromUri] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
