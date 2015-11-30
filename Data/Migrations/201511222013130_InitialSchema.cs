namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "gcommunitydb.equipment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        reference = c.String(maxLength: 255, storeType: "nvarchar"),
                        state = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.simplemember",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DTYPE = c.String(nullable: false, maxLength: 31, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        server = c.String(maxLength: 255, storeType: "nvarchar"),
                        summonerName = c.String(maxLength: 255, storeType: "nvarchar"),
                        surname = c.String(maxLength: 255, storeType: "nvarchar"),
                        username = c.String(maxLength: 255, storeType: "nvarchar"),
                        xp = c.Double(),
                        approved = c.Boolean(),
                        phone = c.Int(),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        membership_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("gcommunitydb.membership", t => t.membership_id)
                .Index(t => t.membership_id);
            
            CreateTable(
                "gcommunitydb.event",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        fee = c.Double(),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        numberOfParticipants = c.Int(nullable: false),
                        lieu = c.String(maxLength: 255, storeType: "nvarchar"),
                        numberOfPlaces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.membership",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fee = c.Single(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.message",
                c => new
                    {
                        idMessage = c.Int(nullable: false),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(precision: 0),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        activeMember_id = c.Int(),
                        idto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idMessage)
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMember_id)
                .Index(t => t.activeMember_id);
            
            CreateTable(
                "gcommunitydb.notification",
                c => new
                    {
                        idNotif = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        etat = c.Int(nullable: false),
                        activeMember_id = c.Int(),
                        message_fk = c.Int(),
                    })
                .PrimaryKey(t => t.idNotif)
                .ForeignKey("gcommunitydb.message", t => t.message_fk)
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMember_id)
                .Index(t => t.activeMember_id)
                .Index(t => t.message_fk);
            
            CreateTable(
                "gcommunitydb.news",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.simplemember_model3d",
                c => new
                    {
                        simpleMember_id = c.Int(nullable: false),
                        model3Ds_id = c.Int(nullable: false),
                        simpleMembers_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.simpleMember_id, t.model3Ds_id, t.simpleMembers_id })
                .ForeignKey("gcommunitydb.model3d", t => t.model3Ds_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMember_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMembers_id, cascadeDelete: true)
                .Index(t => t.simpleMember_id)
                .Index(t => t.model3Ds_id)
                .Index(t => t.simpleMembers_id);
            
            CreateTable(
                "gcommunitydb.model3d",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        datePost = c.DateTime(precision: 0),
                        img = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.simplemember_packs",
                c => new
                    {
                        simpleMember_id = c.Int(nullable: false),
                        packss_id = c.Int(nullable: false),
                        simpleMembers_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.simpleMember_id, t.packss_id, t.simpleMembers_id })
                .ForeignKey("gcommunitydb.packs", t => t.packss_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMember_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMembers_id, cascadeDelete: true)
                .Index(t => t.simpleMember_id)
                .Index(t => t.packss_id)
                .Index(t => t.simpleMembers_id);
            
            CreateTable(
                "gcommunitydb.packs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        category = c.String(maxLength: 255, storeType: "nvarchar"),
                        datemiseenligne = c.DateTime(precision: 0),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        price = c.Single(),
                        quantity = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.simplemember_streams",
                c => new
                    {
                        activeMembers_id = c.Int(nullable: false),
                        streamsss_id = c.Int(nullable: false),
                        simpleMember_id = c.Int(nullable: false),
                        streamss_id = c.Int(nullable: false),
                        simpleMembers_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.activeMembers_id, t.streamsss_id, t.simpleMember_id, t.streamss_id, t.simpleMembers_id })
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMembers_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMembers_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMember_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.streams", t => t.streamss_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.streams", t => t.streamsss_id, cascadeDelete: true)
                .Index(t => t.activeMembers_id)
                .Index(t => t.streamsss_id)
                .Index(t => t.simpleMember_id)
                .Index(t => t.streamss_id)
                .Index(t => t.simpleMembers_id);
            
            CreateTable(
                "gcommunitydb.streams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date_diffusion = c.DateTime(precision: 0),
                        viewers = c.Int(),
                        winner = c.String(maxLength: 255, storeType: "nvarchar"),
                        url = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.simplemember_tutorial",
                c => new
                    {
                        simpleMember_id = c.Int(nullable: false),
                        tutorials_id = c.Int(nullable: false),
                        simpleMembers_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.simpleMember_id, t.tutorials_id, t.simpleMembers_id })
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMembers_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMember_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.tutorial", t => t.tutorials_id, cascadeDelete: true)
                .Index(t => t.simpleMember_id)
                .Index(t => t.tutorials_id)
                .Index(t => t.simpleMembers_id);
            
            CreateTable(
                "gcommunitydb.tutorial",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        rate = c.Int(),
                        tutolev = c.Int(),
                        simplemember_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("gcommunitydb.simplemember", t => t.simplemember_id)
                .Index(t => t.simplemember_id);
            
            CreateTable(
                "gcommunitydb.sponsor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        contribution = c.String(maxLength: 255, storeType: "nvarchar"),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        level = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "gcommunitydb.vote",
                c => new
                    {
                        voted = c.Int(nullable: false),
                        voter = c.Int(nullable: false),
                        year = c.Int(),
                    })
                .PrimaryKey(t => new { t.voted, t.voter })
                .ForeignKey("gcommunitydb.simplemember", t => t.voter, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.voted, cascadeDelete: true)
                .Index(t => t.voted)
                .Index(t => t.voter);
            
            CreateTable(
                "gcommunitydb.simplemember_equipment",
                c => new
                    {
                        activeMembers_id = c.Int(nullable: false),
                        equipments_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.activeMembers_id, t.equipments_id })
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMembers_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.equipment", t => t.equipments_id, cascadeDelete: true)
                .Index(t => t.activeMembers_id)
                .Index(t => t.equipments_id);
            
            CreateTable(
                "gcommunitydb.simplemember_event",
                c => new
                    {
                        events_id = c.Int(nullable: false),
                        simpleMember_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.events_id, t.simpleMember_id })
                .ForeignKey("gcommunitydb.event", t => t.events_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.simpleMember_id, cascadeDelete: true)
                .Index(t => t.events_id)
                .Index(t => t.simpleMember_id);
            
            CreateTable(
                "gcommunitydb.simplemember_news",
                c => new
                    {
                        activeMembers_id = c.Int(nullable: false),
                        news_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.activeMembers_id, t.news_id })
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMembers_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.news", t => t.news_id, cascadeDelete: true)
                .Index(t => t.activeMembers_id)
                .Index(t => t.news_id);
            
            CreateTable(
                "gcommunitydb.simplemember_sponsor",
                c => new
                    {
                        sponsors_id = c.Int(nullable: false),
                        activeMembers_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.sponsors_id, t.activeMembers_id })
                .ForeignKey("gcommunitydb.sponsor", t => t.sponsors_id, cascadeDelete: true)
                .ForeignKey("gcommunitydb.simplemember", t => t.activeMembers_id, cascadeDelete: true)
                .Index(t => t.sponsors_id)
                .Index(t => t.activeMembers_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("gcommunitydb.vote", "voted", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.vote", "voter", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_sponsor", "activeMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_sponsor", "sponsors_id", "gcommunitydb.sponsor");
            DropForeignKey("gcommunitydb.simplemember_tutorial", "tutorials_id", "gcommunitydb.tutorial");
            DropForeignKey("gcommunitydb.tutorial", "simplemember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_tutorial", "simpleMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_tutorial", "simpleMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_streams", "streamsss_id", "gcommunitydb.streams");
            DropForeignKey("gcommunitydb.simplemember_streams", "streamss_id", "gcommunitydb.streams");
            DropForeignKey("gcommunitydb.simplemember_streams", "simpleMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_streams", "activeMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_streams", "simpleMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_packs", "simpleMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_packs", "simpleMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_packs", "packss_id", "gcommunitydb.packs");
            DropForeignKey("gcommunitydb.simplemember_model3d", "simpleMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_model3d", "simpleMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_model3d", "model3Ds_id", "gcommunitydb.model3d");
            DropForeignKey("gcommunitydb.simplemember_news", "news_id", "gcommunitydb.news");
            DropForeignKey("gcommunitydb.simplemember_news", "activeMembers_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.message", "activeMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.notification", "activeMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.notification", "message_fk", "gcommunitydb.message");
            DropForeignKey("gcommunitydb.simplemember", "membership_id", "gcommunitydb.membership");
            DropForeignKey("gcommunitydb.simplemember_event", "simpleMember_id", "gcommunitydb.simplemember");
            DropForeignKey("gcommunitydb.simplemember_event", "events_id", "gcommunitydb.event");
            DropForeignKey("gcommunitydb.simplemember_equipment", "equipments_id", "gcommunitydb.equipment");
            DropForeignKey("gcommunitydb.simplemember_equipment", "activeMembers_id", "gcommunitydb.simplemember");
            DropIndex("gcommunitydb.simplemember_sponsor", new[] { "activeMembers_id" });
            DropIndex("gcommunitydb.simplemember_sponsor", new[] { "sponsors_id" });
            DropIndex("gcommunitydb.simplemember_news", new[] { "news_id" });
            DropIndex("gcommunitydb.simplemember_news", new[] { "activeMembers_id" });
            DropIndex("gcommunitydb.simplemember_event", new[] { "simpleMember_id" });
            DropIndex("gcommunitydb.simplemember_event", new[] { "events_id" });
            DropIndex("gcommunitydb.simplemember_equipment", new[] { "equipments_id" });
            DropIndex("gcommunitydb.simplemember_equipment", new[] { "activeMembers_id" });
            DropIndex("gcommunitydb.vote", new[] { "voter" });
            DropIndex("gcommunitydb.vote", new[] { "voted" });
            DropIndex("gcommunitydb.tutorial", new[] { "simplemember_id" });
            DropIndex("gcommunitydb.simplemember_tutorial", new[] { "simpleMembers_id" });
            DropIndex("gcommunitydb.simplemember_tutorial", new[] { "tutorials_id" });
            DropIndex("gcommunitydb.simplemember_tutorial", new[] { "simpleMember_id" });
            DropIndex("gcommunitydb.simplemember_streams", new[] { "simpleMembers_id" });
            DropIndex("gcommunitydb.simplemember_streams", new[] { "streamss_id" });
            DropIndex("gcommunitydb.simplemember_streams", new[] { "simpleMember_id" });
            DropIndex("gcommunitydb.simplemember_streams", new[] { "streamsss_id" });
            DropIndex("gcommunitydb.simplemember_streams", new[] { "activeMembers_id" });
            DropIndex("gcommunitydb.simplemember_packs", new[] { "simpleMembers_id" });
            DropIndex("gcommunitydb.simplemember_packs", new[] { "packss_id" });
            DropIndex("gcommunitydb.simplemember_packs", new[] { "simpleMember_id" });
            DropIndex("gcommunitydb.simplemember_model3d", new[] { "simpleMembers_id" });
            DropIndex("gcommunitydb.simplemember_model3d", new[] { "model3Ds_id" });
            DropIndex("gcommunitydb.simplemember_model3d", new[] { "simpleMember_id" });
            DropIndex("gcommunitydb.notification", new[] { "message_fk" });
            DropIndex("gcommunitydb.notification", new[] { "activeMember_id" });
            DropIndex("gcommunitydb.message", new[] { "activeMember_id" });
            DropIndex("gcommunitydb.simplemember", new[] { "membership_id" });
            DropTable("gcommunitydb.simplemember_sponsor");
            DropTable("gcommunitydb.simplemember_news");
            DropTable("gcommunitydb.simplemember_event");
            DropTable("gcommunitydb.simplemember_equipment");
            DropTable("gcommunitydb.vote");
            DropTable("gcommunitydb.sponsor");
            DropTable("gcommunitydb.tutorial");
            DropTable("gcommunitydb.simplemember_tutorial");
            DropTable("gcommunitydb.streams");
            DropTable("gcommunitydb.simplemember_streams");
            DropTable("gcommunitydb.packs");
            DropTable("gcommunitydb.simplemember_packs");
            DropTable("gcommunitydb.model3d");
            DropTable("gcommunitydb.simplemember_model3d");
            DropTable("gcommunitydb.news");
            DropTable("gcommunitydb.notification");
            DropTable("gcommunitydb.message");
            DropTable("gcommunitydb.membership");
            DropTable("gcommunitydb.event");
            DropTable("gcommunitydb.simplemember");
            DropTable("gcommunitydb.equipment");
        }
    }
}
