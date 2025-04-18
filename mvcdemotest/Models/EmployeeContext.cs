using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcdemotest.Models
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext() : base("EmployeeContext")  // connection string name
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
