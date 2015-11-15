using Autofac;
using Dungeon_World_Manager.ViewModels;
using Dungeon_World_Manager.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Infrastructure.Modules
{
    public class DefaultWiringModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var assemblies = new List<Assembly>();
            assemblies.Add(Assembly.GetExecutingAssembly());

            foreach (var assembly in assemblies)
            {
                builder
                    .RegisterAssemblyTypes(assembly)
                    .AsImplementedInterfaces();
            }

            builder.Register<IViewModel>(c => new ViewModel()).SingleInstance();
        }
    }
}
