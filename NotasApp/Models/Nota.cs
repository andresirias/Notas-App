﻿using System.ComponentModel.DataAnnotations;

namespace NotasApp.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
    }
}
