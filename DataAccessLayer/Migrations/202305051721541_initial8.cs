namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Rating");
            DropColumn("dbo.Books", "Likes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Likes", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Rating", c => c.Int(nullable: false));
        }
    }
}
