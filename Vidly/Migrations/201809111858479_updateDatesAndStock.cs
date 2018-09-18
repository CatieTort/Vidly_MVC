namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatesAndStock : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1997-08-13 12:00:00 AM', NumberInStock= 5 WHERE Id= 1");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '2002-12-27 12:00:00 AM', NumberInStock= 2 WHERE Id= 2");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '2012-05-04 12:00:00 AM', NumberInStock= 10 WHERE Id= 3");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '2015-03-06 12:00:00 AM', NumberInStock= 4 WHERE Id= 4");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1965-04-01 12:00:00 AM', NumberInStock= 1 WHERE Id= 5");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1994-12-06 12:00:00 AM', NumberInStock= 0 WHERE Id= 6");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '2017-12-20 12:00:00 AM', NumberInStock= 7 WHERE Id= 7");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1997-12-19 12:00:00 AM', NumberInStock= 2 WHERE Id= 8");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '2009-12-18 12:00:00 AM', NumberInStock= 2 WHERE Id= 9");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1996-06-22 12:00:00 AM', NumberInStock= 10 WHERE Id= 10");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1999-08-06 12:00:00 AM', NumberInStock= 4 WHERE Id= 11");
            Sql("UPDATE Movies SET DateAdded= '2017-09-08 12:00:00 AM', ReleaseDate= '1991-02-13 12:00:00 AM', NumberInStock= 6 WHERE Id= 12");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
