namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "Resim_HelpLink", c => c.String());
            AddColumn("dbo.Makales", "Resim_Source", c => c.String());
            AddColumn("dbo.Makales", "Resim_HResult", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Makales", "Resim_HResult");
            DropColumn("dbo.Makales", "Resim_Source");
            DropColumn("dbo.Makales", "Resim_HelpLink");
        }
    }
}
