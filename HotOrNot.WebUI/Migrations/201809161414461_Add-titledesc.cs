namespace HotOrNot.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtitledesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "FilePath", c => c.String());
            AddColumn("dbo.Pictures", "Title", c => c.String());
            AddColumn("dbo.Pictures", "Description", c => c.String());
            DropColumn("dbo.Pictures", "FileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "FileName", c => c.String());
            DropColumn("dbo.Pictures", "Description");
            DropColumn("dbo.Pictures", "Title");
            DropColumn("dbo.Pictures", "FilePath");
        }
    }
}
