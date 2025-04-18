using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleforEntityframework.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
       
    }
}