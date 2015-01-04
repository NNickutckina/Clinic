using Feonufry.CUI.Menu.Builders;
using Library.Actions;
using Library.DomainModel;
using Library.Repositories;
using System;
using Library.Services;

namespace Library
{
    public class ConsoleUI
    {

        public IRepository<Patient> _patientRepository = new MemoryRepository<Patient>();
        public IRepository<ServiceType> _serviceTypeRepository = new MemoryRepository<ServiceType>();
        public IRepository<Doctor> _doctorRepository = new MemoryRepository<Doctor>();
        public IRepository<Visit> _visitRepository = new MemoryRepository<Visit>();
        public IRepository<Insurance> _insuranceRepository = new MemoryRepository<Insurance>();
        public IRepository<Policy> _policyRepository = new MemoryRepository<Policy>();

        public void Run()
        {
            var dataGenerator = new DataGenerator(_patientRepository, _serviceTypeRepository, _doctorRepository, _visitRepository, _insuranceRepository, _policyRepository);
            dataGenerator.Generate();

            new MenuBuilder()
                .Title("Stomatological clinic\n")
                .Item("View patients", new ViewPatientsAction(_patientRepository))
                .Item("View doctors", new ViewDoctorsAction(_doctorRepository))
                .Item("View service types", new ViewServiceTypesAction(_serviceTypeRepository))
                .Item("View visits", new ViewVisitsAction(_visitRepository))
                .Item("Add service", new AddServiceAction(_visitRepository, _serviceTypeRepository))
                .Exit("Exit")
                .GetMenu().Run();
        }
    }
}
