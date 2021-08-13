using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoEncuesta.Models
{
    public class Campo
    {
        [Key]
        public int CampoID { get; set; }
        public int EncuestaID { get; set; }
        public string NombreCampo { get; set; }
        public string TituloCampo { get; set; }
        public int EsRequerido { get; set; }
        public string TipoCampo { get; set; }

        public virtual Encuesta Encuesta { get; set; }
    }
}