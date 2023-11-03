using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data.Infrastructure
{
    public interface IDbFactory
    {
        _1015bookstoreDbContext Init();
    }
}
