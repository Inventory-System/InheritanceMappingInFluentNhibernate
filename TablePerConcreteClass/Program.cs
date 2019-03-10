using InheritanceMapping;
using InheritanceMapping3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePerConcreteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = FluentNHibernateHelper.OpenSesseion())
            {
                //    using (var transaction = session.BeginTransaction())
                //    {
                //        var person1 = new Person
                //        {
                //            FirstName = "Emily"
                //            ,
                //            LastName = "Parker"
                //            ,
                //            NationalIdentityNumber = 00001
                //            ,
                //            EmailAddress = "Emily@example.com"
                //            ,
                //            Address = "EmilyAddress"
                //            ,
                //            PhoneNumber = 11111
                //        };

                //        var person2 = new Person
                //        {
                //            FirstName = "Sofia"
                //            ,
                //            LastName = "Henderson"
                //            ,
                //            NationalIdentityNumber = 00002
                //            ,
                //            EmailAddress = "Sofia@example.com"
                //            ,
                //            Address = "SofiaAddress"
                //            ,
                //            PhoneNumber = 22222
                //        };

                //        var person3 = new Person
                //        {
                //            FirstName = "John"
                //            ,
                //            LastName = "Smith"
                //            ,
                //            NationalIdentityNumber = 00003
                //            ,
                //            EmailAddress = "John@example.com"
                //            ,
                //            Address = "SmithAddress"
                //            ,
                //            PhoneNumber = 33333
                //        };

                //        var company1 = new Company
                //        {
                //            CompanyName = "Nomatec",
                //            CompanyID = 0000011,
                //            Industry = "ERP Systems",
                //            Website = "www.nomatec.net",
                //            EmailAddress = "info@nomatec.net",
                //            Address = "NomatecAddress",
                //            PhoneNumber = 111111,
                //            FaxNumber = 0000111
                //        };

                //        var company2 = new Company
                //        {
                //            CompanyName = "Sony",
                //            CompanyID = 0000022,
                //            Industry = "Conglomerate",
                //            Website = "www.sony.net",
                //            EmailAddress = "info@Sony.net",
                //            Address = "SonyAddress",
                //            PhoneNumber = 222222,
                //            FaxNumber = 0000222
                //        };


                //        session.SaveOrUpdate(person1);
                //        session.SaveOrUpdate(person2);
                //        session.SaveOrUpdate(person3);

                //        session.SaveOrUpdate(company1);
                //        session.SaveOrUpdate(company2);


                //        transaction.Commit();
                //    }
                //}
            }
        }
    }
}