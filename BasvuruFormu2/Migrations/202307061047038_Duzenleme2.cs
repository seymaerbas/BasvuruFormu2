namespace BasvuruFormu2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Duzenleme2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gezis", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gezis", "Status");
        }
    }
}
