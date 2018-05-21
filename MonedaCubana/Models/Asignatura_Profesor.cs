namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asignatura_Profesor
    {
        public int ID { get; set; }

        [Required]
        public long CI { get; set; }

        [Required]
        public int TallerID { get; set; }/*Nombre { get; set; }*/

        public virtual Profesor Profesor { get; set; }

        public virtual Taller Taller { get; set; }
    }
}
