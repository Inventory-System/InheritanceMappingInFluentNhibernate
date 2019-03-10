using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using InheritanceMapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TablePerType;


namespace InheritanceMapping3
{
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    CreatSessionFactory();
                return _sessionFactory;
            }
        }

        public static ISessionFactory CreatSessionFactory()
        {
            string ConnectionString = "Data Source=H-MORADI;Initial Catalog=Sale;User ID=sa;Password=sa123";
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
            return _sessionFactory;
        }
        public static ISession OpenSesseion()
        {
            return SessionFactory.OpenSession();
        }

    }
}