using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using InheritanceMapping;

namespace InheritanceMapping3
{
    public class CompanyMap : SubclassMap<Company>
    {
        public CompanyMap()
        {
            Map(c => c.CompanyID);
            Map(c => c.CompanyName);
            Map(c => c.FaxNumber);
        }

    }
}