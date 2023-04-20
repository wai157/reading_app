namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "Title", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "Title");
        }
    }
}
