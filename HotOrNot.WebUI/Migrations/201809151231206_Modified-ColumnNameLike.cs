namespace HotOrNot.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedColumnNameLike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "LikeCnt", c => c.Int(nullable: false));
            AddColumn("dbo.Pictures", "DisLikeCnt", c => c.Int(nullable: false));
            DropColumn("dbo.Pictures", "LikeDnt");
            DropColumn("dbo.Pictures", "DisLikeDnt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "DisLikeDnt", c => c.Int(nullable: false));
            AddColumn("dbo.Pictures", "LikeDnt", c => c.Int(nullable: false));
            DropColumn("dbo.Pictures", "DisLikeCnt");
            DropColumn("dbo.Pictures", "LikeCnt");
        }
    }
}
