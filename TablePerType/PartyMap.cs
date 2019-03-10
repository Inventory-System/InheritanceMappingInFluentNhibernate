using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Mapping;
using InheritanceMapping;

namespace InheritanceMapping3
{
    public class PartyMap : ClassMap<Party>
    {
        public PartyMap()
        {
            Id(x => x.Id);
            Map(x => x.Address);
            Map(x => x.PhoneNumber);
            Map(x => x.EmailAddress);
        }
    }
}