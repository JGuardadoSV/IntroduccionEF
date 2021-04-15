namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columna_eliminada : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Alumnoes", "Telefono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumnoes", "Telefono", c => c.String());
        }
    }
}
