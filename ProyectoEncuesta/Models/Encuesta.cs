using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoEncuesta.Models
{
    public class Encuesta
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
 
        public DateTime fechaCreacion { get; set; }

        public virtual ICollection<Campo> Campos { get; set; }
    }
}