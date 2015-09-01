namespace RKSseries.Migrations
{
    using RKSseries.DataAccess.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RKSseries.DataAccess.RKDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RKSseries.DataAccess.RKDbContext context)
        {
            var p1 = new Player { FirstName = "John", LastName = "Doe",  CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p2 = new Player { FirstName = "Frank", LastName = "Doe", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p3 = new Player { FirstName = "Robbie", LastName = "Johnson", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p4 = new Player { FirstName = "Billy", LastName = "Bob", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };

            var t1 = new Team { Name = "Rhinos", CreatedDate = DateTime.Now, Players = new List<Player> { p1, p2 }, UpdatedDate = DateTime.Now };
            var t2 = new Team { Name = "Eagles", CreatedDate = DateTime.Now, Players = new List<Player> { p3, p4 }, UpdatedDate = DateTime.Now };

            p1.Team = t1;
            p2.Team = t1;
            p3.Team = t2;
            p4.Team = t2;

            var game = new Game { Team1 = t1, Team2 = t2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, StartTime = DateTime.Now };

            context.Players.Add(p1);
            context.Players.Add(p2);
            context.Players.Add(p3);
            context.Players.Add(p4);
            context.Teams.Add(t1);
            context.Teams.Add(t2);
            context.Games.Add(game);
        }
    }
}
