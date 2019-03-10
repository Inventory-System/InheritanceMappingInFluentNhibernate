using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace InheritanceMapping
{
    class PartyMap : ClassMap<Party>
    {
        public PartyMap()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.Id);
            Map(x => x.PhoneNumber);
            Map(x => x.EmailAddress);
            Map(x => x.Address);
        }
    }
}