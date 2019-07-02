using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFE.Web.Models
{
    public class InterShipSheetViewModel
    {
        public int IdIntershipSheet { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Issue { get; set; }
        public string Fonctionality { get; set; }
        public string Keyword { get; set; }
        public string PersoMail { get; set; }
        public string PeroMail { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string State { get; set; }

        public SheetCategory SheetCategory { get; set; }


        public List<Domain.Entities.Action> Actionlist { get; set; }

        public int SheetCategoryFK { get; set; }

        public virtual IntershipAgreementShhet IntershipAgreementShhet { get; set; }
        public int IntershipAgreementShhetFK { get; set; }
    }
}