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
    public class ListService : Service<IntershipSheet>, IListService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public ListService() : base(unit)
        {

        }

        public void ListFiche(IntershipSheet E)
        {

            var A = unit.getRepository<IntershipSheet>().GetAll();



        }
    }


}
