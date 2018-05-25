namespace MonedaCubana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atributosannosexperienciayespecialidadenprofesorcomopublicos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profesor", "Annos_Experiencia", c => c.Int(nullable: false));
            AddColumn("dbo.Profesor", "Especialidad", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesor", "Especialidad");
            DropColumn("dbo.Profesor", "Annos_Experiencia");
        }
    }
}
