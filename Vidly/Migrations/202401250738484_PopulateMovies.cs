namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek', 3, 2010-01-01, 2024-01-01, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Pulp Fiction', 2, 2010-01-01, 2024-01-01, 8)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Kingsman', 1, 2010-01-01, 2024-01-01, 3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Gladiator', 2, 2010-01-01, 2024-01-01, 6)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Predator', 1, 2010-01-01, 2024-01-01, 9)");
        }
        
        public override void Down()
        {
        }
    }
}
