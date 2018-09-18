namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Customers ON");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (1,'Janet Smith', 0, 1)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (2,'Paul Ryan', 0, 2)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (3,'Caroline Thompson', 0, 4)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (4,'Jack Hellier', 1, 3)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (5,'Carmina Diaz', 0, 1)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (6,'Geroge Jackson', 0, 1)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (7,'Kelly Pinkerton', 0, 3)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (8,'Winston Hurbert', 0, 3)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (9,'Sam Burton', 0, 4)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES (10,'Leo Keld', 0, 1)");
            Sql("SET IDENTITY_INSERT Customers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
