using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Infra
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}