namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trabajador")]
    public partial class Trabajador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        [Required]
        [StringLength(40)]
        public string Ocupacion { get; set; }

        public double Salario { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
