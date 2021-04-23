namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Alumnos", "IdCarrera_FK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumnos", "IdCarrera_FK", c => c.Int(nullable: false));
        }
    }
}
