
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        MyContext DataContext { get; }
    }

}
