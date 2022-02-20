using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Rover.Abstract;
using Mars_Rover.Concrete;

namespace Mars_Rover.DependcyResolvers.AutoFac
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Plateau>().As<ISpace>().SingleInstance();
            builder.RegisterType<Rover>().As<IVehicle>().SingleInstance();
        }
    }
}
