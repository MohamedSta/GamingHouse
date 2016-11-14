using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gaming.data.Models;

namespace gaming.data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        gaminghousedbContext DataContext { get; }
    }

}
