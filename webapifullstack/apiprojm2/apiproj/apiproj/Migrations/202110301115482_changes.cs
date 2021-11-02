namespace apiproj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "desc", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "desc", c => c.Int(nullable: false));
        }
    }
}
