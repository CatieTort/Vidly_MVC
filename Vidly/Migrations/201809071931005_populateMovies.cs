namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (1, 'The Full Monty', 2)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (2, 'Chicago', 6)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (3, 'Avengers', 4)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (4, 'Cinderella', 3)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (5, 'The Sound of Music', 6)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (6, 'Dumb and Dumber', 2)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (7, 'The Greatest Showman', 6)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (8, 'Titanic', 3)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (9, 'Avatar', 4)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (10, 'Mission Impossible', 4)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (11, 'The Sixth Sense', 1)");
            Sql("INSERT INTO Movies (Id, Name, GenereId) VALUES (12, 'Silence of the Lambs', 5)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
