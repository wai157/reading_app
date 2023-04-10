using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbCreate: CreateDatabaseIfNotExists<PBL3DbContext>
    {
        protected override void Seed(PBL3DbContext context)
        {
            //base.Seed(context);
        }
    }
}
