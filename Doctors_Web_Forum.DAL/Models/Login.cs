﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors_Web_Forum.DAL.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter email to login !"),EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Please enter Username !")]
        public string ? Username { get; set; }

        [Required(ErrorMessage ="Please enter password to login !")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
