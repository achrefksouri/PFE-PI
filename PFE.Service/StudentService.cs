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
    public class StudentService: Service<Student>, IStudentService
    {
        List<Student> StudentsNoSheet;

        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);
        public StudentService():base(unit)
        {

        }
        //List<Student> StNoSheet(DateTime annee)

        //{
        //    var st = GetAll();
        //    //foreach (var item in st Where(x => x.age == 20))
        //    //{
        //    //    item.Name = " Mr " + item.Name;
        //    //}
        //    return StudentsNoSheet;
        //}
        public int nbrtotdesetudiants()
        {
            return GetAll().Count();
        }
    }
}
