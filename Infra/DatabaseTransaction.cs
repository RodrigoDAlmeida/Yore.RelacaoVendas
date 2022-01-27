using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Text;

namespace Infra
{
    public class DatabaseTransaction
    {
        private DatabaseTransaction()
        {

        }

        public static DbContextTransaction CreateDbContextTransaction(DatabaseContext db)
        {
            return db.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }
    }
}
