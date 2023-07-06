namespace BasvuruFormu2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Duzenleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forms", "TC", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "TC", c => c.String());
        }
    }
}
