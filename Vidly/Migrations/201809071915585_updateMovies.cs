namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genere_Id1", "dbo.Generes");
            DropIndex("dbo.Movies", new[] { "Genere_Id1" });
            DropColumn("dbo.Movies", "Genere_Id");
            DropColumn("dbo.Movies", "Genere_Id1");
            DropTable("dbo.Generes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Generes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Genere_Id1", c => c.Int());
            AddColumn("dbo.Movies", "Genere_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genere_Id1");
            AddForeignKey("dbo.Movies", "Genere_Id1", "dbo.Generes", "Id");
        }
    }
}
