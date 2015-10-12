using System.Collections.Generic;
using System.Reflection;

namespace ContainerRegister.DependencyManager
{
    public interface IAssemblyLoader
    {
        IList<Assembly> GetAssemblies();
    }
}
