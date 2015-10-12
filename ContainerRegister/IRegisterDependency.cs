using Autofac;

namespace ContainerRegister.DependencyManager
{
    public interface IRegisterDependency
    {
        void Register(ContainerBuilder builder);

        int Order { get; }
    }
}
