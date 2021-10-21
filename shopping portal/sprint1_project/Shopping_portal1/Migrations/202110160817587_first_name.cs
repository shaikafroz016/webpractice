namespace Shopping_portal1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "first_name", c => c.String());
            AddColumn("dbo.User", "last_name", c => c.String());
            AddColumn("dbo.User", "username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "username");
            DropColumn("dbo.User", "last_name");
            DropColumn("dbo.User", "first_name");
        }
    }
}
