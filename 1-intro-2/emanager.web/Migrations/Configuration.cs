namespace emanager.web.Migrations
{
    using ClassLibrary1;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<emanager.web.Infastracture.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(emanager.web.Infastracture.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department() { Name = "Depa1" },
                new Department() { Name = "Depa2" },
                new Department() { Name = "Depa3" },
                new Department() { Name = "Depa4" });
        }
    }
}
