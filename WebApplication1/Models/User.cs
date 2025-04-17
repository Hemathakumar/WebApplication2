using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class User
    {
      [Required(ErrorMessage ="Name field is required")]
     
        public string Username { get; set; }

        [EmailAddress(ErrorMessage ="invalid email address")]
        [Required(ErrorMessage = "Email field is required")]
        public string Email { get; set; }

    
        [Required(ErrorMessage = "Name field is required")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="not matched with Password")]
        public string ConfirmPassword { get; set; }
        [Range(18,99,ErrorMessage ="Age must be between 18 and 99.")]
        public int Age { get; set; }
    }

    public class UserModel
    {
        public User users { get; set;}
        public Employee employees { get; set;}
    }
}