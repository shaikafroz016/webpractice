namespace Shopping_portal1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "first_name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.User", "last_name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.User", "username", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.User", "password", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.User", "gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "gender", c => c.String());
            AlterColumn("dbo.User", "password", c => c.String());
            AlterColumn("dbo.User", "username", c => c.String());
            AlterColumn("dbo.User", "last_name", c => c.String());
            AlterColumn("dbo.User", "first_name", c => c.String());
        }
    }
}
