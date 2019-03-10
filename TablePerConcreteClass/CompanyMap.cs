using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace InheritanceMapping
{
    public class CompanyMap : SubclassMap<Company>
    {
        public CompanyMap()
        {
            Abstract();
            Map(x => x.CompanyName);
            Map(x => x.CompanyID);
            Map(x => x.Industry);
            Map(x => x.Website);
            Map(x => x.FaxNumber);
        }
    }
}