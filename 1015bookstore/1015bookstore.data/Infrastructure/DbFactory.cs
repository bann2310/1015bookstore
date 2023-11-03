using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data.Infrastructure
{
    public class DbFactory:Dispoable, IDbFactory
    {
        private _1015bookstoreDbContext dbContext;

        public _1015bookstoreDbContext Init()
        {
            return dbContext ?? (dbContext = new _1015bookstoreDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
