namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Makales", "MakaleResmi", c => c.Binary());
            DropColumn("dbo.Makales", "Resim_HelpLink");
            DropColumn("dbo.Makales", "Resim_Source");
            DropColumn("dbo.Makales", "Resim_HResult");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Makales", "Resim_HResult", c => c.Int(nullable: false));
            AddColumn("dbo.Makales", "Resim_Source", c => c.String());
            AddColumn("dbo.Makales", "Resim_HelpLink", c => c.String());
            DropColumn("dbo.Makales", "MakaleResmi");
        }
    }
}
