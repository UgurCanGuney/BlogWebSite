namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "Icerik", c => c.String());
            DropColumn("dbo.Makales", "İcerik");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Makales", "İcerik", c => c.String());
            DropColumn("dbo.Makales", "Icerik");
        }
    }
}
