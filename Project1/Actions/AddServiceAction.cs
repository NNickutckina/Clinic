using System;
using System.Collections.Generic;
using System.Linq;
using Feonufry.CUI.Actions;
using Library.Repositories;
using Library.DomainModel;
using Feonufry.CUI.Menu.Builders;

namespace Library.Actions
{
    public class AddServiceAction : IAction
    {
        private readonly IRepository<Visit> _visitRepository;
        private readonly IRepository<ServiceType> _serviceTypeRepository;

        public AddServiceAction(IRepository<Visit> visitRepository, IRepository<ServiceType> serviceTypeRepository)
        {
            _visitRepository = visitRepository;
            _serviceTypeRepository = serviceTypeRepository;
        }

        public void Perform(ActionExecutionContext context)
        {
            Console.Clear();
            var visits = _visitRepository.AsQueryable().ToList();
            var VisitCheckMenu = new MenuBuilder()
                .RunnableOnce()
                .Title("Choose visit");
            Visit selectedVisit = new Visit();
            foreach (var visit in visits)
            {
                var visitId = visit.Identifier;
                VisitCheckMenu.Item(string.Format("Doctor: {0} Patient: {1} Date: {2}", visit.Doctor.Name, visit.Policy.Patient.Name, visit.DateTime), ctx => selectedVisit = _visitRepository.Get(visitId));
            }
            VisitCheckMenu.GetMenu().Run();

            Console.Clear();
            var services = _serviceTypeRepository.AsQueryable().ToList();
            var ServiceCheckMenu = new MenuBuilder()
                .RunnableOnce()
                .Title("Choose service");
            ServiceType selectedService = new ServiceType();
            foreach (var service in services)
            {
                var serviceId = service.Identifier;
                ServiceCheckMenu.Item(string.Format("Name: {0} Code: {1} Cost: {2}", service.Name, service.Code, service.Cost), ctx => selectedService = _serviceTypeRepository.Get(serviceId));
            }
            ServiceCheckMenu.GetMenu().Run();

            selectedVisit.Status = VisitStatus.InProgress;
            selectedVisit.AddService(new Service (20m, selectedService));
        }
    }
}