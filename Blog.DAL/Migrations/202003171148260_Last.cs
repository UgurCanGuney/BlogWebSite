namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Last : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Makales", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Makales", "CategoryId");
            AddForeignKey("dbo.Makales", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Makales", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Makales", new[] { "CategoryId" });
            DropColumn("dbo.Makales", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
