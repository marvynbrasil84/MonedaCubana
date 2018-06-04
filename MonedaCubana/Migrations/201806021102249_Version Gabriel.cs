namespace MonedaCubana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VersionGabriel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        Telefono_Padre = c.Int(),
                        Telefono_Madre = c.Int(),
                        Nombre_Padre = c.String(maxLength: 100),
                        Nombre_Madre = c.String(maxLength: 100),
                        Categoria = c.String(nullable: false, maxLength: 20),
                        Foto = c.Binary(storeType: "image"),
                        NombreGrupo = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CI)
                .ForeignKey("dbo.Grupo", t => t.NombreGrupo)
                .ForeignKey("dbo.Persona", t => t.CI)
                .Index(t => t.CI)
                .Index(t => t.NombreGrupo);
            
            CreateTable(
                "dbo.Alumno_Preparatoria",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        ID_Preparatoria = c.Int(nullable: false),
                        Aprobado = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Observacion = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => new { t.CI, t.ID_Preparatoria })
                .ForeignKey("dbo.Preparatoria", t => t.ID_Preparatoria)
                .ForeignKey("dbo.Alumno", t => t.CI)
                .Index(t => t.CI)
                .Index(t => t.ID_Preparatoria);
            
            CreateTable(
                "dbo.Preparatoria",
                c => new
                    {
                        ID_Preparatoria = c.Int(nullable: false, identity: true),
                        Nombre_Taller = c.String(nullable: false, maxLength: 100),
                        Fecha_Inicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Fecha_Fin = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ID_Preparatoria);
            
            CreateTable(
                "dbo.Asignatura_Alumno",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        TallerID = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 30, unicode: false),
                        Nota = c.Double(),
                        ID_Registro = c.Long(),
                    })
                .PrimaryKey(t => new { t.CI, t.TallerID })
                .ForeignKey("dbo.Registro", t => t.ID_Registro)
                .ForeignKey("dbo.Taller", t => t.TallerID)
                .ForeignKey("dbo.Alumno", t => t.CI)
                .Index(t => t.CI)
                .Index(t => t.TallerID)
                .Index(t => t.ID_Registro);
            
            CreateTable(
                "dbo.Registro",
                c => new
                    {
                        ID_Registro = c.Long(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID_Registro)
                .ForeignKey("dbo.Grupo", t => t.Nombre)
                .Index(t => t.Nombre);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        NombreGrupo = c.String(nullable: false, maxLength: 20),
                        Sesion = c.String(nullable: false, maxLength: 20),
                        Periodo = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.NombreGrupo)
                .ForeignKey("dbo.Programa_Entrenamiento", t => t.Periodo)
                .Index(t => t.Periodo);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        Categoria_Docente = c.String(maxLength: 40),
                        Categoria_Cientifica = c.String(maxLength: 40),
                        Salario = c.Double(nullable: false),
                        Annos_Experiencia = c.Int(nullable: false),
                        Especialidad = c.String(),
                    })
                .PrimaryKey(t => t.CI)
                .ForeignKey("dbo.Persona", t => t.CI)
                .Index(t => t.CI);
            
            CreateTable(
                "dbo.Asignatura_Profesor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CI = c.Long(nullable: false),
                        TallerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Taller", t => t.TallerID)
                .ForeignKey("dbo.Profesor", t => t.CI)
                .Index(t => t.CI)
                .Index(t => t.TallerID);
            
            CreateTable(
                "dbo.Taller",
                c => new
                    {
                        TallerID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 30),
                        Periodo = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.TallerID)
                .ForeignKey("dbo.Programa_Entrenamiento", t => t.Periodo)
                .Index(t => t.Periodo);
            
            CreateTable(
                "dbo.Programa_Entrenamiento",
                c => new
                    {
                        Periodo = c.String(nullable: false, maxLength: 20),
                        Plan_Curricular = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Periodo);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        Militancia = c.String(maxLength: 100),
                        Raza = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Sexo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Nivel_Escolar = c.String(nullable: false, maxLength: 100),
                        Fecha_Nacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Direccion = c.String(maxLength: 100),
                        Telefono = c.Int(),
                        Correo = c.String(maxLength: 100),
                        Lugar_Nacimiento = c.String(maxLength: 100),
                        Nacionalidad = c.String(nullable: false, maxLength: 100),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Primer_Apellido = c.String(maxLength: 100),
                        Segundo_Apellido = c.String(maxLength: 100),
                        Fecha_Inicio_Contrato = c.DateTime(nullable: false, storeType: "date"),
                        Fecha_Fin_Contrato = c.DateTime(nullable: false, storeType: "date"),
                        Numero_Contrato = c.Int(nullable: false),
                        Provincia = c.String(),
                        Municipio = c.String(),
                    })
                .PrimaryKey(t => t.CI);
            
            CreateTable(
                "dbo.Telefono_Persona",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        Numero = c.Long(),
                    })
                .PrimaryKey(t => t.CI)
                .ForeignKey("dbo.Persona", t => t.CI)
                .Index(t => t.CI);
            
            CreateTable(
                "dbo.Trabajador",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        Ocupacion = c.String(nullable: false, maxLength: 40),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CI)
                .ForeignKey("dbo.Persona", t => t.CI)
                .Index(t => t.CI);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Rol = c.String(nullable: false, maxLength: 100),
                        Contrasena = c.String(nullable: false, maxLength: 100),
                        CI = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Nombre)
                .ForeignKey("dbo.Persona", t => t.CI)
                .Index(t => t.CI);
            
            CreateTable(
                "dbo.Ubicación",
                c => new
                    {
                        CI = c.Long(nullable: false),
                        ID_Trabajo = c.Int(nullable: false),
                        Motivo_Cancelacion = c.String(nullable: false, maxLength: 200),
                        Ocupacion = c.String(nullable: false, maxLength: 100),
                        Tipo_Asignacion = c.String(maxLength: 100),
                        Fecha_Inicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Fecha_Fin = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.CI, t.ID_Trabajo })
                .ForeignKey("dbo.Centro_Trabajo", t => t.ID_Trabajo)
                .ForeignKey("dbo.Alumno", t => t.CI)
                .Index(t => t.CI)
                .Index(t => t.ID_Trabajo);
            
            CreateTable(
                "dbo.Centro_Trabajo",
                c => new
                    {
                        ID_Trabajo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.ID_Trabajo);
            
            CreateTable(
                "dbo.Grupo_Profesor",
                c => new
                    {
                        NombreGrupo = c.String(nullable: false, maxLength: 20),
                        CI = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.NombreGrupo, t.CI })
                .ForeignKey("dbo.Grupo", t => t.NombreGrupo, cascadeDelete: true)
                .ForeignKey("dbo.Profesor", t => t.CI, cascadeDelete: true)
                .Index(t => t.NombreGrupo)
                .Index(t => t.CI);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubicación", "CI", "dbo.Alumno");
            DropForeignKey("dbo.Ubicación", "ID_Trabajo", "dbo.Centro_Trabajo");
            DropForeignKey("dbo.Asignatura_Alumno", "CI", "dbo.Alumno");
            DropForeignKey("dbo.Registro", "Nombre", "dbo.Grupo");
            DropForeignKey("dbo.Grupo_Profesor", "CI", "dbo.Profesor");
            DropForeignKey("dbo.Grupo_Profesor", "NombreGrupo", "dbo.Grupo");
            DropForeignKey("dbo.Usuario", "CI", "dbo.Persona");
            DropForeignKey("dbo.Trabajador", "CI", "dbo.Persona");
            DropForeignKey("dbo.Telefono_Persona", "CI", "dbo.Persona");
            DropForeignKey("dbo.Profesor", "CI", "dbo.Persona");
            DropForeignKey("dbo.Alumno", "CI", "dbo.Persona");
            DropForeignKey("dbo.Asignatura_Profesor", "CI", "dbo.Profesor");
            DropForeignKey("dbo.Taller", "Periodo", "dbo.Programa_Entrenamiento");
            DropForeignKey("dbo.Grupo", "Periodo", "dbo.Programa_Entrenamiento");
            DropForeignKey("dbo.Asignatura_Profesor", "TallerID", "dbo.Taller");
            DropForeignKey("dbo.Asignatura_Alumno", "TallerID", "dbo.Taller");
            DropForeignKey("dbo.Alumno", "NombreGrupo", "dbo.Grupo");
            DropForeignKey("dbo.Asignatura_Alumno", "ID_Registro", "dbo.Registro");
            DropForeignKey("dbo.Alumno_Preparatoria", "CI", "dbo.Alumno");
            DropForeignKey("dbo.Alumno_Preparatoria", "ID_Preparatoria", "dbo.Preparatoria");
            DropIndex("dbo.Grupo_Profesor", new[] { "CI" });
            DropIndex("dbo.Grupo_Profesor", new[] { "NombreGrupo" });
            DropIndex("dbo.Ubicación", new[] { "ID_Trabajo" });
            DropIndex("dbo.Ubicación", new[] { "CI" });
            DropIndex("dbo.Usuario", new[] { "CI" });
            DropIndex("dbo.Trabajador", new[] { "CI" });
            DropIndex("dbo.Telefono_Persona", new[] { "CI" });
            DropIndex("dbo.Taller", new[] { "Periodo" });
            DropIndex("dbo.Asignatura_Profesor", new[] { "TallerID" });
            DropIndex("dbo.Asignatura_Profesor", new[] { "CI" });
            DropIndex("dbo.Profesor", new[] { "CI" });
            DropIndex("dbo.Grupo", new[] { "Periodo" });
            DropIndex("dbo.Registro", new[] { "Nombre" });
            DropIndex("dbo.Asignatura_Alumno", new[] { "ID_Registro" });
            DropIndex("dbo.Asignatura_Alumno", new[] { "TallerID" });
            DropIndex("dbo.Asignatura_Alumno", new[] { "CI" });
            DropIndex("dbo.Alumno_Preparatoria", new[] { "ID_Preparatoria" });
            DropIndex("dbo.Alumno_Preparatoria", new[] { "CI" });
            DropIndex("dbo.Alumno", new[] { "NombreGrupo" });
            DropIndex("dbo.Alumno", new[] { "CI" });
            DropTable("dbo.Grupo_Profesor");
            DropTable("dbo.Centro_Trabajo");
            DropTable("dbo.Ubicación");
            DropTable("dbo.Usuario");
            DropTable("dbo.Trabajador");
            DropTable("dbo.Telefono_Persona");
            DropTable("dbo.Persona");
            DropTable("dbo.Programa_Entrenamiento");
            DropTable("dbo.Taller");
            DropTable("dbo.Asignatura_Profesor");
            DropTable("dbo.Profesor");
            DropTable("dbo.Grupo");
            DropTable("dbo.Registro");
            DropTable("dbo.Asignatura_Alumno");
            DropTable("dbo.Preparatoria");
            DropTable("dbo.Alumno_Preparatoria");
            DropTable("dbo.Alumno");
        }
    }
}
