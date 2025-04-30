using demotest3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demotest3.Controllers
{
    public class ValuesController : ApiController
    {
        List<Employee> TempEmployee = new List<Employee>();

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Salary = 75000 },
            new Employee { Id = 3, Name = "Carol White", Department = "Finance", Salary = 68000 },
            new Employee { Id = 4, Name = "David Brown", Department = "Marketing", Salary = 62000 },
            new Employee { Id = 5, Name = "Eva Green", Department = "IT", Salary = 80000 }
        };
        }
        // GET api/values
        public IEnumerable<Employee> Get()
        {
             
            return TempEmployee;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        public IEnumerable<Employee> Post([FromBody] Employee emp)
        {
            TempEmployee = GetEmployees();
            TempEmployee.Add(emp);
            return TempEmployee;
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
