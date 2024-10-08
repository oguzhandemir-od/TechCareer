using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace efp.VeriErisimi
{
    public class ilksatisInitializer:DropCreateDatabaseIfModelChanges<SatisContext>
    {
        protected override void Seed(SatisContext context)
        {

            base.Seed(context);
        }
    }
}