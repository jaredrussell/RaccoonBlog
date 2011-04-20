﻿using System.ComponentModel.DataAnnotations;
using System.Security;

namespace RavenDbBlog.ViewModels
{
    public class LoginInput
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Password")]
        [UIHint("String")]
        public SecureString Password { get; set; }
    }
}