﻿using System.ComponentModel.DataAnnotations;

namespace UserLoginForm.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Display(Name = "Remenber me")]

        public bool RememberMe { get; set; }
    }
}
