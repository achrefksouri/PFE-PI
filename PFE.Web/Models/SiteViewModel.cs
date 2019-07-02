using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFE.Web.Models
{
    public class SiteViewModel
    {
        public int IdSite { get; set; }
        public string Label { get; set; }
        public School School { get; set; }

        public int SchoolFK { get; set; }

        public List<Departement> DepartementList { get; set; }
    }
}