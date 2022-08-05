using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Module = Autofac.Module;

namespace QuickSave.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).Where(t => t.Name.EndsWith("Factory")).SingleInstance();
        }
    }
}
