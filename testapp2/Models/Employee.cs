﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testapp2.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class FeedbackModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }

}