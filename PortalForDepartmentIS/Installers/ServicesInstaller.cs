using BLL.Abstraction;
using BLL.Implementation;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DAL.DataAccessLayer;

namespace PortalForDepartmentIS.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IPostManager>().ImplementedBy<PostManager>().LifestyleTransient());

            container.Register(Component.For<DatabaseContext>());

        }
    }
}