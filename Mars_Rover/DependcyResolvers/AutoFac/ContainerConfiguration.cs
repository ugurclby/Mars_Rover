using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Mars_Rover.DependcyResolvers.AutoFac
{
    public static class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            var container = new ContainerBuilder();
            container.RegisterModule<ProgramModule>();
            return container.Build();
        }
    }
}
