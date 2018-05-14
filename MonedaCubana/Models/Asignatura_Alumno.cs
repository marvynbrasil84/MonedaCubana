namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asignatura_Alumno
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public double? Nota { get; set; }

        public long? ID_Registro { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Registro Registro { get; set; }

        public virtual Taller Taller { get; set; }
    }
}
