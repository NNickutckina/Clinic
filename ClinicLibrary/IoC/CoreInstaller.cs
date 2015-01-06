using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ClinicLibrary.Repositories;
using ClinicLibrary.Services;

namespace ClinicLibrary.IoC
{
    public class CoreInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(MemoryRepository<>)));
            container.Register(Component.For<DataGenerator>());
        }
    }
}