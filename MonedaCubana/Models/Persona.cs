namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Usuario = new List<Usuario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        [StringLength(100)]
        public string Militancia { get; set; }

        [Required]
        [StringLength(30)]
        public string Raza { get; set; }

        [Required]
        [StringLength(30)]
        public string Sexo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nivel_Escolar { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Nacimiento { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        public int? Telefono { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(100)]
        public string Lugar_Nacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public string Nacionalidad { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Primer_Apellido { get; set; }

        [StringLength(100)]
        public string Segundo_Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Inicio_Contrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Fin_Contrato { get; set; }

        public int Numero_Contrato { get; set; }

        public string Provincia { get; set; }

        public string Municipio { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Telefono_Persona Telefono_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }

        public virtual Profesor Profesor { get; set; }

        public virtual Trabajador Trabajador { get; set; }
    }
}
