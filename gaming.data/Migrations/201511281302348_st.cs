namespace gaming.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class st : DbMigration
    {
        public override void Up()
        {
           // DropPrimaryKey("dbo.event");
            CreateTable(
                "dbo.tournament",
                c => new
                    {
                        idtournament = c.Long(nullable: false, identity: true),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.String(maxLength: 255, storeType: "nvarchar"),
                        ImageUrl = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idtournament);
            
           // AddColumn("dbo.event", "Pic", c => c.String(maxLength: 255, storeType: "nvarchar"));
          //  AddColumn("dbo.news", "Image", c => c.String(maxLength: 255, storeType: "nvarchar"));
          //  AlterColumn("dbo.event", "id", c => c.Long(nullable: false, identity: true));
          //  AddPrimaryKey("dbo.event", "id");
         //   DropColumn("dbo.event", "ImageUrl");
         //   DropColumn("dbo.news", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.news", "ImageUrl", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.event", "ImageUrl", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropPrimaryKey("dbo.event");
            AlterColumn("dbo.event", "id", c => c.Long(nullable: false));
            DropColumn("dbo.news", "Image");
            DropColumn("dbo.event", "Pic");
            DropTable("dbo.tournament");
            AddPrimaryKey("dbo.event", "id");
        }
    }
}
