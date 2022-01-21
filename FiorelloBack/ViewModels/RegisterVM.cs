﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [StringLength(maximumLength:25)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Fullname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public bool Terms { get; set; }
    }
}
