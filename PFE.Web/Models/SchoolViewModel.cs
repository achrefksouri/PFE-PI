using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFE.Web.Models
{
    public class SchoolViewModel
    {
        public int IdSchool { get; set; }
        public string LabelShcool { get; set; }
        public string Country { get; set; }
        public List<Site> Siteslist { get; set; }
    }
}