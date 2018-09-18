namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGeneres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Generes (Id, Name) VALUES (1, 'Thriller')");
            Sql("INSERT INTO Generes (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Generes (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO Generes (Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO Generes (Id, Name) VALUES (5, 'Horror')");
            Sql("INSERT INTO Generes (Id, Name) VALUES (6, 'Musical')");
        }
        
        public override void Down()
        {
        }
    }
}
