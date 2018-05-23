namespace MonedaCubana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoProvinciayMunicipiotablapersona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persona", "Provincia", c => c.String());
            AddColumn("dbo.Persona", "Municipio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persona", "Municipio");
            DropColumn("dbo.Persona", "Provincia");
        }
    }
}
