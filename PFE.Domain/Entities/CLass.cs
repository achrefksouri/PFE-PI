﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class CLass
    {
        public  int IdClass { get; set; }
        public string label { get; set; }

        //propriétes de navigation
        public Option Option { get; set; }
        public AcademicYear AcademicYear { get; set; }

       

        public List<Student> StudentList { get; set; }

        
        public int AcademicYearFK { get; set; }
        public int OptionFK { get; set; }
       


    }
}
