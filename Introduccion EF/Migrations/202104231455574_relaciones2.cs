namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnos", "IdCarrera_FK", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumnos", "IdCarrera_FK");
        }
    }
}
