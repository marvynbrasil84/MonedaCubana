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

        public long CI { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        public virtual Profesor Profesor { get; set; }

        public virtual Taller Taller { get; set; }
    }
}
