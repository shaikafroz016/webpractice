namespace Shopping_portal1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class username : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "username", c => c.String());
        }
    }
}
