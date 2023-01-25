namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MakaleBaslik = c.String(),
                        İcerik = c.String(),
                        Yazar = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Makales");
        }
    }
}
