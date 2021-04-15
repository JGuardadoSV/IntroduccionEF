namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnoes");
        }
    }
}
