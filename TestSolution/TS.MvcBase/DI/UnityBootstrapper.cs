using Microsoft.Practices.Unity;
using TS.ServiceInterfaces;
using TS.Services;
using TS.RepositoryInterfaces;
using TS.Repositories;

namespace TS.MvcBase.DI
{
    public partial class UnityBootstrapper
    {
        public static void ConfigureContainer(UnityContainer container)
        {
            if (container == null)
                container = new UnityContainer();

            container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITestRepository, TestRepository>();
            
            //container.RegisterType<IRoleService, RoleService>();
            //container.RegisterType<IRoleRepository, RoleRepository>();
        }
    }
}
