namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columna_nueva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnoes", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumnoes", "Telefono");
        }
    }
}
