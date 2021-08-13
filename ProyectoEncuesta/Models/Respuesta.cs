using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProyectoEncuesta.Models
{
    public class Respuesta
    {

        [Key]
        public int ID { get; set; }
        [Key]
        public virtual Campo Campo { get; set; }
        public string DesRespuesta { get; set; }

    }
}