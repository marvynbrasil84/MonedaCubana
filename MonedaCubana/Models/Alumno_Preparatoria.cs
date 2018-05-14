namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alumno_Preparatoria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Preparatoria { get; set; }

        [Required]
        [StringLength(1)]
        public string Aprobado { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Preparatoria Preparatoria { get; set; }
    }
}
