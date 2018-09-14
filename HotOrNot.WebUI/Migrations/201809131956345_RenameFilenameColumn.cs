namespace HotOrNot.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameFilenameColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "FileName", c => c.String());
            DropColumn("dbo.Pictures", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "Content", c => c.String());
            DropColumn("dbo.Pictures", "FileName");
        }
    }
}
