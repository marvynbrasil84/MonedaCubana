namespace MonedaCubana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiandoeltamannoeneldataanottationdelmodelopersona : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persona", "Raza", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
            AlterColumn("dbo.Persona", "Sexo", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persona", "Sexo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Persona", "Raza", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
        }
    }
}
