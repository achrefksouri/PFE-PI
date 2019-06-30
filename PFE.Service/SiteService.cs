using PFE.Data.Infrastructures;
using PFE.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Service
{
 public   class SiteService: Service<Site>,ISite
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public SiteService():base(unit)
        {

        }
    }
}
