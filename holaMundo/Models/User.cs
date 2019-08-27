using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace holaMundo.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string nombre { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        [Index(IsUnique = true)]
        public string email { get; set; }

        [Required]
        [StringLength(200)]
        public string apellido { get; set; }

        [Required]
        public DateTime add { get; set; }
        [Required]
        public int ProfesionFk { get; set; }

        [ForeignKey("ProfesionFk")]
        public Profesion Profesion { get; set; }

    }
}