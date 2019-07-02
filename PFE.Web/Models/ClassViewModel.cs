using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFE.Web.Models
{
    public class ClassViewModel
    {
        [Key]
        public int IdClass { get; set; }
        public string label { get; set; }

        //propriétes de navigation
        public Option Option { get; set; }
        public OptionViewModel options { get; set; }
        public int AcademicYear { get; set; }



        public List<Student> StudentList { get; set; }



        public int OptionFK { get; set; }


    }
}