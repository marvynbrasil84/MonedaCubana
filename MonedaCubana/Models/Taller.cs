namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taller")]
    public partial class Taller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taller()
        {
            Asignatura_Alumno = new List<Asignatura_Alumno>();
            Asignatura_Profesor = new List<Asignatura_Profesor>();
        }

        [Key]
        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string Periodo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignatura_Alumno> Asignatura_Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignatura_Profesor> Asignatura_Profesor { get; set; }

        public virtual Programa_Entrenamiento Programa_Entrenamiento { get; set; }
    }
}
