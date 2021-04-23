namespace Introduccion_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumnos");
            RenameColumn(table: "dbo.Alumnos", name: "Nombre", newName: "Nombre_Alumno");
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        IdCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.IdCarrera);
            
            AddColumn("dbo.Alumnos", "Carrera_IdCarrera", c => c.Int());
            AlterColumn("dbo.Alumnos", "Nombre_Alumno", c => c.String(maxLength: 25));
            CreateIndex("dbo.Alumnos", "Carrera_IdCarrera");
            AddForeignKey("dbo.Alumnos", "Carrera_IdCarrera", "dbo.Carreras", "IdCarrera");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnos", "Carrera_IdCarrera", "dbo.Carreras");
            DropIndex("dbo.Alumnos", new[] { "Carrera_IdCarrera" });
            AlterColumn("dbo.Alumnos", "Nombre_Alumno", c => c.String());
            DropColumn("dbo.Alumnos", "Carrera_IdCarrera");
            DropTable("dbo.Carreras");
            RenameColumn(table: "dbo.Alumnos", name: "Nombre_Alumno", newName: "Nombre");
            RenameTable(name: "dbo.Alumnos", newName: "Alumnoes");
        }
    }
}
