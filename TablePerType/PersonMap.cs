using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using InheritanceMapping;
namespace InheritanceMapping3
{
    public class PersonMap : SubclassMap<Person>
    {
        public PersonMap()
        {
            Map(x => x.NationalIdentityNumber);
            Map(x => x.LastName);
            Map(x => x.FirstName);
        }
    }
}