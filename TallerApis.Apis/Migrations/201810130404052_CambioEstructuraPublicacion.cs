namespace TallerApis.Apis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publicacion", "Descripcion", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publicacion", "Descripcion", c => c.String(maxLength: 200));
        }
    }
}
