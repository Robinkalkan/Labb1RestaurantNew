﻿using System.ComponentModel.DataAnnotations;

namespace Labb1Restaurant.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}