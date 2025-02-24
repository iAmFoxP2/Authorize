﻿using System.ComponentModel.DataAnnotations;

namespace Authorize.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; } 
    }
}
