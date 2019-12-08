using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<GridEntities>
    {
        protected override void Seed(GridEntities context)
        {
            Dep dep = new Dep()
            {
                Name = "Math",

            };
            context.Deps.Add(dep);
            context.SaveChanges();
            base.Seed(context);
        }

    }
}