namespace csharpdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Publisher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .Index(t => t.Publisher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Titles", "Publisher_Id", "dbo.Publishers");
            DropIndex("dbo.Titles", new[] { "Publisher_Id" });
            DropTable("dbo.Titles");
            DropTable("dbo.Publishers");
        }
    }
}
