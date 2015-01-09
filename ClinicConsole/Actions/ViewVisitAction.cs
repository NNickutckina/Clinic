using System;
using Feonufry.CUI.Actions;
using ClinicLibrary.Repositories;
using ClinicLibrary.DomainModel;
using ClinicLibrary.Services;
using System.Linq;

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

            var visits = _visitRepository.AsQueryable().ToList();

            foreach (var visit in visits)
            {
                Console.WriteLine("Doctor: {2} Policy: {3} Time: {0} {1}", visit.DateTime, visit.Description, visit.Doctor.Name, visit.Policy.Patient.Name);
                Console.WriteLine("Service total cost: {0}", CostService.GetVisitCost(visit));
            }
        }
    }
}