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
                .Index(t => t.AccountId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Notifications", "AccountId", "Accounts");
            DropIndex("Notifications", new[] { "BookId" });
            DropIndex("Notifications", new[] { "AccountId" });
            DropTable("Notifications");
        }
    }
}
