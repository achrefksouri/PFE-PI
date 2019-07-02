using PFE.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Service
{
  public  interface IStudentService: IService<Student>
    {
        //public List<Student> StNoSheet(DateTime annee);
        // public void StNoSheet(DateTime annee);
        int nbrtotdesetudiants();
    }
}
