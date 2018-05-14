namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Rol { get; set; }

        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }

        public long CI { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
