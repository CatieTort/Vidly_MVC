namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBirthdates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '12/03/1968' WHERE Id = 1 ");
            Sql("UPDATE Customers SET BirthDate = '2/13/1998' WHERE Id = 2 ");
            Sql("UPDATE Customers SET BirthDate = '5/08/1989' WHERE Id = 3 ");
            Sql("UPDATE Customers SET BirthDate = '11/20/1988' WHERE Id = 4 ");
            Sql("UPDATE Customers SET BirthDate = '08/10/2000' WHERE Id = 5 ");
            Sql("UPDATE Customers SET BirthDate = '04/30/2001' WHERE Id = 6 ");
            Sql("UPDATE Customers SET BirthDate = '09/25/1987' WHERE Id = 7 ");
            Sql("UPDATE Customers SET BirthDate = '10/19/1999' WHERE Id = 8 ");
            Sql("UPDATE Customers SET BirthDate = '06/14/1992' WHERE Id = 9 ");
            Sql("UPDATE Customers SET BirthDate = '09/07/1990' WHERE Id = 10 ");
        }
        
        public override void Down()
        {
        }
    }
}
