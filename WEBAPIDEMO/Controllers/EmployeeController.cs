using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIDEMO.Models;

namespace WEBAPIDEMO.Controllers
{
    public class EmployeeController : ApiController
    {
        //Get 
        public IEnumerable<Employee> Get()
        {
            localDBEntities1 localDBEntities1 = new localDBEntities1();

            return localDBEntities1.Employees.ToList();
        }
        //post
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {

                localDBEntities1 localDBEntities1 = new localDBEntities1();
                localDBEntities1.Employees.Add(employee);
                localDBEntities1.SaveChanges();
                return Request.CreateErrorResponse(HttpStatusCode.OK, employee.ToString());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee record was not inserted into localDBEntities1");
            }


        }
        //Put
        public HttpResponseMessage Put(int id, [FromBody] Employee employee)
        {
            try
            {

                localDBEntities1 localDBEntities1 = new localDBEntities1();
                var entity = localDBEntities1.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id=" + id + " not found on the Employee table");
                }
                else
                {
                    entity.Name = employee.Name;
                    entity.Department = employee.Department;
                    entity.Salary = employee.Salary;
                    localDBEntities1.SaveChanges();
                }
                return Request.CreateErrorResponse(HttpStatusCode.OK, "Employee with id=" + id + "updated on the table");

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee record was not inserted into localDBEntities1");
            }


        }
        //Delete
        public IHttpActionResult Delete(int id)
        {
            try
            {

                localDBEntities1 localDBEntities1 = new localDBEntities1();
                var entity = localDBEntities1.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return NotFound();
                }
                else
                {
                    localDBEntities1.Employees.Remove(entity);
                    localDBEntities1.SaveChanges();
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        public IHttpActionResult patch(int id)
        {
            try
            {

                localDBEntities1 localDBEntities1 = new localDBEntities1();
                var entity = localDBEntities1.Employees.FirstOrDefault(e => e.Id == id);
                if (entity == null)
                {
                    return NotFound();
                }
                else
                {
                    localDBEntities1.Employees.Remove(entity);
                    localDBEntities1.SaveChanges();
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
