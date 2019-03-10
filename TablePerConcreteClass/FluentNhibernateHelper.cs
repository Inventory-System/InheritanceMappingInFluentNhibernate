//using FluentNHibernate.Cfg;
//using FluentNHibernate.Cfg.Db;
//using InheritanceMapping;
//using NHibernate;
//using NHibernate.Tool.hbm2ddl;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceMapping
//{
//    public class FluentNHibernateHelper
//    {
//        private static ISessionFactory _sessionFactory;
//        private static ISessionFactory SessionFactory
//        {
//            get
//            {
//                if (_sessionFactory == null)
//                    CreatSessionFactory();
//                return _sessionFactory;
//            }
//        }

//       private static ISessionFactory CreatSessionFactory()
//        {
//            string ConnectionString = "Data Source=T-SAFARI;Initial Catalog=InheritanchTestDB;User ID=sa;Password=s@123456";// Write your Connect String here
//            _sessionFactory = Fluently.Configure()
//                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString).ShowSql())
//                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
//                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
//                .BuildSessionFactory();
//            return _sessionFactory;
//        }
//        public static ISession OpenSesseion()
//        {
//            return SessionFactory.OpenSession();
//        }

//    }
//}