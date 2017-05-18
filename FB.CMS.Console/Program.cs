using Autofac;
using FB.CMS.Console.Interface;
using FB.CMS.Console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.CMS.Console
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DatabaseLog>().As<ILog>();
            Container = builder.Build();

            ILog log = Container.Resolve<ILog>();
            log.Id = 1;
            log.Write();
        }
    }
}
