using PFE.Data.Infrastructures;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Service
{
   public class EmployeeService: Service<Domain.Entities.Employee>, IEmployeeService

    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public EmployeeService():base(unit)
        {

        }
    }
    
}
