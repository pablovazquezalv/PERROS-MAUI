using System;
using System.ComponentModel.DataAnnotations;

namespace DPAV.Models
{
    public class Raza
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Nombre { get; set; }
        [Required]
        public bool Estado { get; set; } 
    }
}
