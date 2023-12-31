﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PjLeonardoPerosaZagoWeb.Models
{
    public class Psico
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Nome necessário.")]
        [Display(Name = "Nome")]
        public string CRP { get; set; }
        [Required(ErrorMessage = "Nome necessário.")]
        [Display(Name = "Nome")]
        public bool Liberado { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
