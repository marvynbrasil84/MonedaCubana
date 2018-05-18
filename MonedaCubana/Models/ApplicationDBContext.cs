namespace MonedaCubana.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
            : base("name=ApplicationDBContext")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Alumno_Preparatoria> Alumno_Preparatoria { get; set; }
        public virtual DbSet<Asignatura_Alumno> Asignatura_Alumno { get; set; }
        public virtual DbSet<Asignatura_Profesor> Asignatura_Profesor { get; set; }
        public virtual DbSet<Centro_Trabajo> Centro_Trabajo { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Preparatoria> Preparatoria { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Programa_Entrenamiento> Programa_Entrenamiento { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<Taller> Taller { get; set; }
        public virtual DbSet<Telefono_Persona> Telefono_Persona { get; set; }
        public virtual DbSet<Trabajador> Trabajador { get; set; }
        public virtual DbSet<Ubicación> Ubicación { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Asignatura_Alumno)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Ubicación)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Alumno_Preparatoria)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alumno_Preparatoria>()
                .Property(e => e.Aprobado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Asignatura_Alumno>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Trabajo>()
                .Property(e => e.Nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Trabajo>()
                .HasMany(e => e.Ubicación)
                .WithRequired(e => e.Centro_Trabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.Registro)
                .WithOptional(e => e.Grupo)
                .HasForeignKey(e => e.Nombre);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.Profesor)
                .WithMany(e => e.Grupo)
                .Map(m => m.ToTable("Grupo_Profesor").MapLeftKey("NombreGrupo").MapRightKey("CI"));

            modelBuilder.Entity<Persona>()
                .Property(e => e.Raza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Alumno)
                .WithRequired(e => e.Persona);

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Telefono_Persona)
                .WithRequired(e => e.Persona);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Profesor)
                .WithRequired(e => e.Persona);

            modelBuilder.Entity<Persona>()
                .HasOptional(e => e.Trabajador)
                .WithRequired(e => e.Persona);

            modelBuilder.Entity<Preparatoria>()
                .HasMany(e => e.Alumno_Preparatoria)
                .WithRequired(e => e.Preparatoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.Asignatura_Profesor)
                .WithRequired(e => e.Profesor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taller>()
                .HasMany(e => e.Asignatura_Alumno)
                .WithRequired(e => e.Taller)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taller>()
                .HasMany(e => e.Asignatura_Profesor)
                .WithRequired(e => e.Taller)
                .WillCascadeOnDelete(false);
        }
    }
}
