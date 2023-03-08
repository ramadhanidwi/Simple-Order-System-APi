﻿using Simple_Order_System_APi.Models;
using System.ComponentModel.DataAnnotations;

namespace Simple_Order_System_APi.ViewModels
{
    public class RegisterVM
    {
        [MaxLength(2), MinLength(2, ErrorMessage = "ex: S1/D3")]
        [Required(ErrorMessage = "Tidak Boleh Kosong ex: D3/S1")]
        public string Degree { get; set; }

        [Range(0, 4, ErrorMessage = "Inputan Harus Lebih dari {1} dan Kurang dari {2}")]
        public float GPA { get; set; }

        public string UniversityName { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
