using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleforEntityframework.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext():base("DBEntityConnection")
        {

        }
        public DbSet<Employee> employees { set; get; }
        public DbSet<Product> products { set; get; }
    }
}