namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Asignatura_Alumno = new List<Asignatura_Alumno>();
            Ubicación = new List<Ubicación>();
            Alumno_Preparatoria = new List<Alumno_Preparatoria>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        public int? Telefono_Padre { get; set; }

        public int? Telefono_Madre { get; set; }

        [StringLength(100)]
        public string Nombre_Padre { get; set; }

        [StringLength(100)]
        public string Nombre_Madre { get; set; }

        [Required]
        [StringLength(20)]
        public string Categoria { get; set; }

        [Column(TypeName = "image")]
        public byte[] Foto { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignatura_Alumno> Asignatura_Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubicación> Ubicación { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno_Preparatoria> Alumno_Preparatoria { get; set; }

        public virtual Grupo Grupo { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
