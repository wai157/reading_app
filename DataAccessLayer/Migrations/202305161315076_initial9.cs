namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Content = c.String(unicode: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "BookId", "dbo.Books");
            DropForeignKey("dbo.Notifications", "AccountId", "dbo.Accounts");
            DropIndex("dbo.Notifications", new[] { "BookId" });
            DropIndex("dbo.Notifications", new[] { "AccountId" });
            DropTable("dbo.Notifications");
        }
    }
}
