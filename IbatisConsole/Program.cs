using Autofac;
using Dao.Dao;
using Dao.IBatisConfig;
using Dao.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbatisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //IUserDao user = new UserDao();

            ContainerBuilder builder = new Autofac.ContainerBuilder();

            builder.RegisterType<UserDao>().As<IUserDao>();

            //builder.RegisterType<TestInterceptor>();
            
            IContainer Container = builder.Build();

            IUserDao user = Container.Resolve<IUserDao>();

            var list = user.GetUsers();

        }
    }
}
