using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private _1015bookstoreDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public _1015bookstoreDbContext DbContext
        { get { return dbContext ?? (dbContext = dbFactory.Init()); } }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
