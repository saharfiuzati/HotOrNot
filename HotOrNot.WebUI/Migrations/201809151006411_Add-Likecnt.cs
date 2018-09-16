namespace HotOrNot.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLikecnt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "LikeDnt", c => c.Int(nullable: false));
            AddColumn("dbo.Pictures", "DisLikeDnt", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pictures", "DisLikeDnt");
            DropColumn("dbo.Pictures", "LikeDnt");
        }
    }
}
