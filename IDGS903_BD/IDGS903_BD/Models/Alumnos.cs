using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS903_BD.Models
{
    public class Alumnos
    {
        [Required]
        public int Id {  get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [StringLength(50)] 
        public string Correo { get; set; }
        
    }
}