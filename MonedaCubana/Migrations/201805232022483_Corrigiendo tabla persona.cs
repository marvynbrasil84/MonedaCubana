namespace MonedaCubana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Corrigiendotablapersona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persona", "Primer_Apellido", c => c.String(maxLength: 100));
            AddColumn("dbo.Persona", "Segundo_Apellido", c => c.String(maxLength: 100));
            AddColumn("dbo.Persona", "Fecha_Inicio_Contrato", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Persona", "Fecha_Fin_Contrato", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Persona", "Numero_Contrato", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persona", "Numero_Contrato");
            DropColumn("dbo.Persona", "Fecha_Fin_Contrato");
            DropColumn("dbo.Persona", "Fecha_Inicio_Contrato");
            DropColumn("dbo.Persona", "Segundo_Apellido");
            DropColumn("dbo.Persona", "Primer_Apellido");
        }
    }
}
