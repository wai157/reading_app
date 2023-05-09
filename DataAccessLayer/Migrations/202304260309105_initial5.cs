namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Verifications", "RequestedDateTime", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Verifications", "RequestedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Verifications", "RequestedDate", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Verifications", "RequestedDateTime");
        }
    }
}
