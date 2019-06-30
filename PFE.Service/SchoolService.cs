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
    public class SchoolService:Service<School>,ISchoolService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public SchoolService():base(unit)
        {

        }
    }
}
