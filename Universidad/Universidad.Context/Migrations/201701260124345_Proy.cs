namespace Universidad.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Alumno", "Apellidos", c => c.String(maxLength: 50));
            AlterColumn("dbo.Alumno", "Nombres", c => c.String(maxLength: 50));
            AlterColumn("dbo.Estado Civil", "Descripcion", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Genero", "Descripcion", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Alumno", "ApellidoPaterno");
            DropColumn("dbo.Alumno", "ApellidoMaterno");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumno", "ApellidoMaterno", c => c.String(maxLength: 60));
            AddColumn("dbo.Alumno", "ApellidoPaterno", c => c.String(maxLength: 60));
            AlterColumn("dbo.Genero", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Estado Civil", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Alumno", "Nombres", c => c.String(maxLength: 100));
            DropColumn("dbo.Alumno", "Apellidos");
            DropColumn("dbo.Alumno", "Created");
        }
    }
}
