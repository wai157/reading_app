namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "IsVerified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "IsVerified");
        }
    }
}
