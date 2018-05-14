namespace MonedaCubana.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Telefono_Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CI { get; set; }

        public long? Numero { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
