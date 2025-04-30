using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using webapp5test.Models;

namespace webapp5test.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
      
        
        public IEnumerable<Employee> Get()
        {
            localDBEntities localDBEntities = new localDBEntities();

            return localDBEntities.Employees.ToList();
        }
        [Route("api/{employee}/{id}")]
        public IHttpActionResult Get(int id)
        {
            localDBEntities localDBEntities = new localDBEntities();
            var entity = localDBEntities.Employees.FirstOrDefault(e => e.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
           
        }

        [Route("api/{employee}/{id}/{name}")]
        public IEnumerable<string> Get(int id, string name)
        {
            return new string[] { id.ToString(), name };
        }
        //post

        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {

                localDBEntities localDBEntities = new localDBEntities();
                localDBEntities.Employees.Add(employee);
                localDBEntities.SaveChanges();
                return Request.CreateErrorResponse(HttpStatusCode.OK, employee.ToString());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee record was not inserted into localDBEntities");
            }


        }
        //Put
        public HttpResponseMessage Put(int id, [FromBody] Employee employee)
        {
            try
            {

                localDBEntities localDBEntities = new localDBEntities();
                var entity = localDBEntities.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id=" + id + " not found on the Employee table");
                }
                else
                {
                    entity.Name = employee.Name;
                    entity.Department = employee.Department;
                    entity.Salary = employee.Salary;
                    localDBEntities.SaveChanges();
                }
                return Request.CreateErrorResponse(HttpStatusCode.OK, "Employee with id=" + id + "updated on the table");

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee record was not inserted into localDBEntities");
            }


        }
        //Delete
        public IHttpActionResult Delete(int id)
        {
            try
            {

                localDBEntities localDBEntities = new localDBEntities();
                var entity = localDBEntities.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return NotFound();
                }
                else
                {
                    localDBEntities.Employees.Remove(entity);
                    localDBEntities.SaveChanges();
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        public IHttpActionResult patch(int id, [FromBody] Employee employee)
        {
            try
            {

                localDBEntities localDBEntities = new localDBEntities();
                var entity = localDBEntities.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return NotFound();
                }
                else
                {
                    entity.Name = employee.Name;
                    entity.Department = employee.Department;
                    entity.Salary = employee.Salary;
                    localDBEntities.SaveChanges();
                   
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }


        }

      
    }
}