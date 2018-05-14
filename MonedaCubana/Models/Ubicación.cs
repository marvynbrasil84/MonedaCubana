namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ubicación
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Trabajo { get; set; }

        [Required]
        [StringLength(200)]
        public string Motivo_Cancelacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Ocupacion { get; set; }

        [StringLength(100)]
        public string Tipo_Asignacion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Fecha_Inicio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Fecha_Fin { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Centro_Trabajo Centro_Trabajo { get; set; }
    }
}
