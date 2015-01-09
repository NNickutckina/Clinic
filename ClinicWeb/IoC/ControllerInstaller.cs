﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ClinicWeb.Controllers;

namespace ClinicWeb.IoC
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                    .InNamespace("ClinicWeb.Controllers")
                    .LifestyleTransient());
        }
    }
}