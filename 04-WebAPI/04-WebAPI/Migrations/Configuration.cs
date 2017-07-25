namespace _04_WebAPI.Migrations
{
    using _04_WebAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_04_WebAPI.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_04_WebAPI.Models.VideoDb context)
        {
            context.Videos.AddOrUpdate(v => v.Title,
                new Video() { Title = "MVC5", Length = 120 },
                new Video() { Title = "LINQ", Length = 200 });

            context.SaveChanges();
        }
    }
}
