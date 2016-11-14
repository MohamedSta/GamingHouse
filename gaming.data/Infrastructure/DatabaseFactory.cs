using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gaming.data.Models;

namespace gaming.data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private gaminghousedbContext dataContext;
        public gaminghousedbContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new gaminghousedbContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
