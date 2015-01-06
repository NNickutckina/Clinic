using Feonufry.CUI.Menu.Builders;
using ClinicLibrary.Actions;
using ClinicLibrary.DomainModel;
using ClinicLibrary.Repositories;
using System;
using ClinicLibrary.Services;
using Castle.Windsor;
using ClinicLibrary.IoC;
using ClinicConsole.IoC;

namespace ClinicLibrary
{
    public class ConsoleUI
    {

        public void Run()
        {
            var container = new WindsorContainer();
            container.Install(new CoreInstaller(), new UIInstaller());

            var dataGenerator = container.Resolve<DataGenerator>();
            dataGenerator.Generate();

            new MenuBuilder()
                .WithActionFactory(new WindsorActionFactory(container))
                .Title("Stomatological clinic\n")
                .Item<ViewPatientsAction>("View patients")
                .Item<ViewDoctorsAction>("View doctors")
                .Item<ViewServiceTypesAction>("View service types")
                .Item<ViewVisitsAction>("View visits")
                .Item<AddServiceAction>("Add service")
                .Exit("Exit")
                .GetMenu().Run();
        }
    }
}
