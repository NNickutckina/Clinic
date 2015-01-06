using System;
using Feonufry.CUI.Actions;
using ClinicLibrary.Repositories;
using ClinicLibrary.DomainModel;

namespace ClinicLibrary.Actions
{
    public class ViewVisitsAction : IAction
    {
        private readonly IRepository<Visit> _visitRepository;

        public ViewVisitsAction(IRepository<Visit> visitRepository)
        {
            _visitRepository = visitRepository;
        }

        public void Perform(ActionExecutionContext context)
        {
            Console.Clear();
            Console.WriteLine("Visits:\n");

            foreach (var visit in _visitRepository.AsQueryable())
            {
                Console.WriteLine("Doctor: {2} Policy: {3} Time: {0} {1}", visit.DateTime, visit.Description, visit.Doctor.Name, visit.Policy.Patient.Name);
                var services = visit.Services;
                decimal totalCost = 0m;
                foreach (var service in services)
                {
                    totalCost += service.Cost;
                    Console.WriteLine("Service {0} cost: {1}", service.ServiceType.Name, service.Cost);
                }
                Console.WriteLine("Service total cost: {0}", totalCost);
            }
        }
    }
}