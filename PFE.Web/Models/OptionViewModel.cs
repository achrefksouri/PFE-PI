using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFE.Web.Models
{
    public class OptionViewModel
    {
        public int IdOption { get; set; }
        public string Label { get; set; }
        public Departement Departement { get; set; }
        public List<CLass> ClassList { get; set; }
        public int DepartementFK { get; set; }
        public List<ClassViewModel> Classes { get; set; }
    }
}