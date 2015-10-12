using ContainerRegister.DependencyManager;
using Autofac;

namespace AutofacDemoWCF
{
    public class RegisterDependencyWCF : IRegisterDependency
    {
        public int Order => 1;

        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<AutofacDemoWCF.Service1>();
            builder.RegisterType<Soma>().As<ICalculo>().InstancePerLifetimeScope();
        }
    }
}