namespace BasvuruFormu2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        TelefonNo = c.String(),
                        Eposta = c.String(),
                        TC = c.String(),
                        DogumTarihi = c.DateTimeOffset(nullable: false, precision: 7),
                        GeziID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Gezis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GeziAdı = c.String(),
                        SehirID = c.Int(nullable: false),
                        IlceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IlceAdi = c.String(),
                        SehirID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sehirs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SehirAdi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sehirs");
            DropTable("dbo.Ilces");
            DropTable("dbo.Gezis");
            DropTable("dbo.Forms");
        }
    }
}
