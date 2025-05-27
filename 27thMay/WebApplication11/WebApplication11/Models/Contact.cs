﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
}