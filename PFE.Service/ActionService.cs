using PFE.Data.Infrastructures;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Service
{
  public  class ActionService : Service<Action>, IActionService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public ActionService():base(unit)
        {

        }
    }
    // ye rabi nchala teslik
    //iuouoiu
    //fjflfdsl
    //mariem*
    //hiigiug
}
