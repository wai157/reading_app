namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        Content = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookReports", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookReports", "AccountID", "dbo.Accounts");
            DropIndex("dbo.BookReports", new[] { "BookID" });
            DropIndex("dbo.BookReports", new[] { "AccountID" });
            DropTable("dbo.BookReports");
        }
    }
}
