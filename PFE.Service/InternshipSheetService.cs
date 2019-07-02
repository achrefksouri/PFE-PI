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
    public class InternshipSheetService : Service<IntershipSheet>, IInternshipSheetService
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public InternshipSheetService() : base(unit)
        {

            //}
            //public IEnumerable<IntershipSheet> listetraitfich()
            //{
            //    var v = GetMany(t => t.State == State.Approved).OfType<IntershipSheet>();
            //    foreach (var item in v)
            //    {
            //        Console.WriteLine("Livre" + item.Titre);
            //    }
            //    return v;
            //}
        }
        //public List<Adherant> ListeAdherant()
        //    //{
        //    //    GetAll().OrderBy(s => s.Email).ToList();
        //    //}
        //public List<IntershipSheet> ListInterSheet()
        //{
        //    ////return GetAll().OrderBy(s => s.Compagny).ToList();
        //}
    }
}

