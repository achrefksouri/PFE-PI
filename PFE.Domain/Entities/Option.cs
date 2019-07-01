﻿using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Option
    {
        public  int IdOption { get; set; }
        public  string  Label { get; set; }
        public Departement Departement { get; set; }
        public List<CLass> ClassList { get; set; }
        public int DepartementFK { get; set; }
    }
}
