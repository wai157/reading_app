﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "IsVerified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "IsVerified");
        }
    }
}
