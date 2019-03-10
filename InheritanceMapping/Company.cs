﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    public class Company : Party
    {
        public virtual int CompanyID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string Industry { get; set; }
        public virtual int FaxNumber { get; set; }
        public virtual string Website { get; set; }
    }
}