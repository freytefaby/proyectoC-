using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace holaMundo.Models
{
    public class Profesion
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string nombre { get; set; }
        public List<User> users { get; set; }
    }
}