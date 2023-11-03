using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data.Infrastructure
{
    public class Dispoable : IDisposable
    {
        private bool isDisposable;

        ~Dispoable() {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!isDisposable && disposing)
            { 
                DisposeCore();
            }  
            isDisposable = true;
        }
        protected virtual void DisposeCore() { }
    }
}
