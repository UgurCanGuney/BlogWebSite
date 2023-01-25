namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Makales", "MakaleResmi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Makales", "MakaleResmi", c => c.Binary());
        }
    }
}
