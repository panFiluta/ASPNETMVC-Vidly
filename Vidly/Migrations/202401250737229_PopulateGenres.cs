﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'For Kids')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
