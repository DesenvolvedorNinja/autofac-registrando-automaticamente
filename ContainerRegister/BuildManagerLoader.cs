using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;

namespace ContainerRegister.DependencyManager
{
    public class BuildManagerLoader : IAssemblyLoader
    {
        public IList<Assembly> GetAssemblies()
        {
            return BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();
        }
    }
}
