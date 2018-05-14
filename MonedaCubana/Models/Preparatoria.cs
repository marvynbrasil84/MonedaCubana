namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Preparatoria")]
    public partial class Preparatoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Preparatoria()
        {
            Alumno_Preparatoria = new List<Alumno_Preparatoria>();
        }

        [Key]
        public int ID_Preparatoria { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre_Taller { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Fecha_Inicio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Fecha_Fin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno_Preparatoria> Alumno_Preparatoria { get; set; }
    }
}
