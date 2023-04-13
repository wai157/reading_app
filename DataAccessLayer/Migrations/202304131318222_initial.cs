namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReadChapterIds = c.String(unicode: false),
                        AccountId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Cover = c.Binary(),
                        Rating = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        Likes = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Int(nullable: false),
                        Content = c.String(unicode: false),
                        Views = c.Int(nullable: false),
                        Likes = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.RatedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(unicode: false),
                        Sex = c.String(unicode: false),
                        DOB = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "Id", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Books", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.RatedBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.RatedBooks", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Libraries", "BookId", "dbo.Books");
            DropForeignKey("dbo.Libraries", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Histories", "BookId", "dbo.Books");
            DropForeignKey("dbo.Chapters", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Histories", "AccountId", "dbo.Accounts");
            DropIndex("dbo.UserInfoes", new[] { "Id" });
            DropIndex("dbo.RatedBooks", new[] { "BookId" });
            DropIndex("dbo.RatedBooks", new[] { "AccountId" });
            DropIndex("dbo.Libraries", new[] { "BookId" });
            DropIndex("dbo.Libraries", new[] { "AccountId" });
            DropIndex("dbo.Chapters", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "AccountId" });
            DropIndex("dbo.Histories", new[] { "BookId" });
            DropIndex("dbo.Histories", new[] { "AccountId" });
            DropIndex("dbo.Accounts", new[] { "RoleId" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Roles");
            DropTable("dbo.RatedBooks");
            DropTable("dbo.Libraries");
            DropTable("dbo.Chapters");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
            DropTable("dbo.Histories");
            DropTable("dbo.Accounts");
        }
    }
}
