using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ContainerRegister.DependencyManager
{
    public class AppDomainLoader : IAssemblyLoader
    {
        public IList<Assembly> GetAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies().ToList();
        }
    }
}
