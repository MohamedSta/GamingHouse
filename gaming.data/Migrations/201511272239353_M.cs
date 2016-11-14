namespace gaming.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.comments",
            //    c => new
            //        {
            //            idComment = c.Long(nullable: false),
            //            contents = c.String(maxLength: 255, storeType: "nvarchar"),
            //            post_idPost = c.Long(),
            //        })
            //    .PrimaryKey(t => t.idComment)
            //    .ForeignKey("dbo.post", t => t.post_idPost)
            //    .Index(t => t.post_idPost);
            
            //CreateTable(
            //    "dbo.post",
            //    c => new
            //        {
            //            idPost = c.Long(nullable: false),
            //            contents = c.String(maxLength: 255, storeType: "nvarchar"),
            //            gamer_idGamer = c.String(maxLength: 128, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idPost);
            
            //CreateTable(
            //    "dbo.equipments",
            //    c => new
            //        {
            //            idEquipments = c.Long(nullable: false),
            //            name = c.String(maxLength: 255, storeType: "nvarchar"),
            //            quantity = c.String(maxLength: 255, storeType: "nvarchar"),
            //            type = c.String(maxLength: 255, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idEquipments);
            
            //CreateTable(
            //    "dbo.event",
            //    c => new
            //        {
            //            id = c.Long(nullable: false),
            //            dateEvent = c.String(maxLength: 255, storeType: "nvarchar"),
            //            title = c.String(maxLength: 255, storeType: "nvarchar"),
            //            type = c.String(maxLength: 255, storeType: "nvarchar"),
            //            ImageUrl = c.String(maxLength: 255, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.games",
            //    c => new
            //        {
            //            idGames = c.Long(nullable: false),
            //            name = c.String(maxLength: 255, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idGames);
            
            //CreateTable(
            //    "dbo.news",
            //    c => new
            //        {
            //            idNews = c.Long(nullable: false),
            //            description = c.String(maxLength: 255, storeType: "nvarchar"),
            //            title = c.String(maxLength: 255, storeType: "nvarchar"),
            //            ImageUrl = c.String(maxLength: 255, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idNews);
            
            //CreateTable(
            //    "dbo.reclamation",
            //    c => new
            //        {
            //            idReclam = c.Long(nullable: false),
            //            content = c.String(maxLength: 255, storeType: "nvarchar"),
            //            subject = c.String(maxLength: 255, storeType: "nvarchar"),
            //            title = c.String(maxLength: 255, storeType: "nvarchar"),
            //            admin_idAdmin = c.String(maxLength: 128, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idReclam);
            
            //CreateTable(
            //    "dbo.schedule",
            //    c => new
            //        {
            //            idSchedule = c.Long(nullable: false),
            //            dateSchedule = c.String(maxLength: 255, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idSchedule);
            
            //CreateTable(
            //    "dbo.sponsor",
            //    c => new
            //        {
            //            idSponsor = c.Int(nullable: false, identity: true),
            //            addressSponsor = c.String(maxLength: 255, storeType: "nvarchar"),
            //            entreprise = c.String(maxLength: 255, storeType: "nvarchar"),
            //            location = c.String(maxLength: 255, storeType: "nvarchar"),
            //            nameSponsor = c.String(maxLength: 255, storeType: "nvarchar"),
            //            phonenumberSponsor = c.String(maxLength: 255, storeType: "nvarchar"),
            //            picture = c.Binary(),
            //            date = c.String(unicode: false),
            //        })
            //    .PrimaryKey(t => t.idSponsor);
            
            //CreateTable(
            //    "dbo.trophy",
            //    c => new
            //        {
            //            idTrophy = c.Long(nullable: false),
            //            date = c.String(maxLength: 255, storeType: "nvarchar"),
            //            name = c.String(maxLength: 255, storeType: "nvarchar"),
            //            type = c.String(maxLength: 255, storeType: "nvarchar"),
            //            gamer_idGamer = c.String(maxLength: 128, storeType: "nvarchar"),
            //        })
            //    .PrimaryKey(t => t.idTrophy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.comments", "post_idPost", "dbo.post");
            DropIndex("dbo.comments", new[] { "post_idPost" });
            DropTable("dbo.trophy");
            DropTable("dbo.sponsor");
            DropTable("dbo.schedule");
            DropTable("dbo.reclamation");
            DropTable("dbo.news");
            DropTable("dbo.games");
            DropTable("dbo.event");
            DropTable("dbo.equipments");
            DropTable("dbo.post");
            DropTable("dbo.comments");
        }
    }
}
