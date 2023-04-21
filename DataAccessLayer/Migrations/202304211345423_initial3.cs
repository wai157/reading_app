namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "Avatar", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "Avatar");
        }
    }
}
