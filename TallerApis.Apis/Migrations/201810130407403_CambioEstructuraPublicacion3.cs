namespace TallerApis.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publicaciones", newName: "Publicacion");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Publicacion", newName: "Publicaciones");
        }
    }
}
