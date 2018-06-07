using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MonedaCubana.Models
{
    public class AlumnoAsociacionTaller
    {
      
        [StringLength(30)]
        public string Nombre { get; set; }

        public int TallerID { get; set; }


        public string Posee { get; set; }

        
    }
}