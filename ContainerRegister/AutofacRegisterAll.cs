using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerRegister.DependencyManager
{
    public static class AutofacRegisterAll
    {
        public static IContainer RegisterDependencies(IList<IAssemblyLoader> loaders)
        {
            ContainerBuilder builder = new ContainerBuilder();
            AppTypeFinder typeFinder = new AppTypeFinder(loaders);
            var drTypes = typeFinder.FindClassesOfType<IRegisterDependency>();
            var drInstances = new List<IRegisterDependency>();
            foreach (var drType in drTypes)
                drInstances.Add((IRegisterDependency)Activator.CreateInstance(drType));

            drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(builder);

            return builder.Build();
        }
    }
}
