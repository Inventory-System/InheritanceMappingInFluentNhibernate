using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using InheritanceMapping;

namespace InheritanceMapping
{
    public class PersonMap : SubclassMap<Person>
    {
        public PersonMap()
        {
            Abstract();
            Map(x => x.NationalIdentityNumber);
            Map(x => x.FirstName);
            Map(x => x.LastName);


        }
    }
}