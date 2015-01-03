using Library.DomainModel;
using Library.Repositories;
using System.Collections.Generic;
using System;

namespace Library.Services
{
    public class DataGenerator
    {
        private readonly IRepository<Patient> _patientRepository;
        private readonly IRepository<ServiceType> _serviceTypeRepository;
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IRepository<Visit> _visitRepository;
        private readonly IRepository<Insurance> _insuranceRepository;
        private readonly IRepository<Policy> _policyRepository;
        private readonly IRepository<Service> _serviceRepository;

        public DataGenerator(IRepository<Patient> patientRepository, IRepository<ServiceType> serviceTypeRepository, IRepository<Doctor> doctorRepository, IRepository<Visit> visitRepository, IRepository<Insurance> insuranceRepository, IRepository<Policy> policyRepository, IRepository<Service> serviceRepository)
        {
            _patientRepository = patientRepository;
            _serviceTypeRepository = serviceTypeRepository;
            _doctorRepository = doctorRepository;
            _visitRepository = visitRepository;
            _insuranceRepository = insuranceRepository;
            _policyRepository = policyRepository;
            _serviceRepository = serviceRepository;
        }

        public void Generate()
        {
            var patient1 = new Patient("Ivanov Ivan");
            var patient2 = new Patient("Sidorov Arseniy");
            var patient3 = new Patient("Markin Sergey");
            var patient4 = new Patient("Maksimov Fedor");
            var patient5 = new Patient("Amelichev Viktor");

            _patientRepository.Add(patient1);
            _patientRepository.Add(patient2);
            _patientRepository.Add(patient3);
            _patientRepository.Add(patient4);
            _patientRepository.Add(patient5);

            var doctor1 = new Doctor("Petrov Petr");
            var doctor2 = new Doctor("Artemov Artem");
            var doctor3 = new Doctor("Savelin Aleksandr");
            var doctor4 = new Doctor("Romanov Dmitriy");
            var doctor5 = new Doctor("Dmitriev Roman");

            _doctorRepository.Add(doctor1);
            _doctorRepository.Add(doctor2);
            _doctorRepository.Add(doctor3);
            _doctorRepository.Add(doctor4);
            _doctorRepository.Add(doctor5);

            var serviceType1 = new ServiceType("Plombing A", "Djf234", 1200.5m);
            var serviceType2 = new ServiceType("Plombing B", "xcfj45", 459.5m);
            var serviceType3 = new ServiceType("Plombing C", "szhser", 320m);
            var serviceType4 = new ServiceType("Plombing D", "dr5472", 650m);
            var serviceType5 = new ServiceType("Plombing E", "cdt7k4", 288m);
            var serviceType6 = new ServiceType("Plombing F", "xdtk46", 1777m);
            var serviceType7 = new ServiceType("Plombing G", "xctuu5", 666.6m);
            var serviceType8 = new ServiceType("Plombing H", "xdfk35", 3776m);
            var serviceType9 = new ServiceType("Plombing I", "ae5i36", 3636m);

            _serviceTypeRepository.Add(serviceType1);
            _serviceTypeRepository.Add(serviceType2);
            _serviceTypeRepository.Add(serviceType3);
            _serviceTypeRepository.Add(serviceType4);
            _serviceTypeRepository.Add(serviceType5);
            _serviceTypeRepository.Add(serviceType6);
            _serviceTypeRepository.Add(serviceType7);
            _serviceTypeRepository.Add(serviceType8);
            _serviceTypeRepository.Add(serviceType9);

            Insurance Alpha = new Insurance("Alpha");
            Insurance Rosno = new Insurance("Rosno");
            Insurance RosGosStrah = new Insurance("RosGosStrah");

            _insuranceRepository.Add(Alpha);
            _insuranceRepository.Add(Rosno);
            _insuranceRepository.Add(RosGosStrah);

            var firstServiceList = new List<ServiceType>();

            firstServiceList.Add(serviceType6);
            firstServiceList.Add(serviceType3);

            var secondServiceList = new List<ServiceType>();

            secondServiceList.Add(serviceType1);
            secondServiceList.Add(serviceType3);
            secondServiceList.Add(serviceType4);
            secondServiceList.Add(serviceType5);
            secondServiceList.Add(serviceType8);

            var thirdServiceList = new List<ServiceType>();

            thirdServiceList.Add(serviceType1);
            thirdServiceList.Add(serviceType3);
            thirdServiceList.Add(serviceType4);

            var policy1 = new Policy("hfr", "234-43", Alpha, firstServiceList, patient1);
            var policy2 = new Policy("zdtj", "235", Rosno, firstServiceList, patient2);
            var policy3 = new Policy("zetj", "732", Alpha, thirdServiceList, patient3);
            var policy4 = new Policy("qwet", "3468", Rosno, firstServiceList, patient4);
            var policy5 = new Policy("mfsj", "892", RosGosStrah, secondServiceList, patient5);

            _policyRepository.Add(policy1);
            _policyRepository.Add(policy2);
            _policyRepository.Add(policy3);
            _policyRepository.Add(policy4);
            _policyRepository.Add(policy5);

            var service1 = new Service(38.5m, serviceType1);
            var service2 = new Service(45m, serviceType2);
            var service3 = new Service(40m, serviceType3);
            var service4 = new Service(25m, serviceType4);
            var service5 = new Service(12.5m, serviceType5);

            _serviceRepository.Add(service1);
            _serviceRepository.Add(service2);
            _serviceRepository.Add(service3);
            _serviceRepository.Add(service4);
            _serviceRepository.Add(service5);

            var visit1 = new Visit(DateTime.Now, "", doctor1, policy1);
            var visit2 = new Visit(DateTime.Now, "", doctor2, policy2);
            var visit3 = new Visit(DateTime.Now, "", doctor3, policy3);
            var visit4 = new Visit(DateTime.Now, "", doctor4, policy4);
            var visit5 = new Visit(DateTime.Now, "", doctor5, policy5);

            _visitRepository.Add(visit1);
            _visitRepository.Add(visit2);
            _visitRepository.Add(visit3);
            _visitRepository.Add(visit4);
            _visitRepository.Add(visit5);
        }
    }
}