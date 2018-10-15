namespace TallerApis.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publicacion", newName: "Publicaciones");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Publicaciones", newName: "Publicacion");
        }
    }
}
