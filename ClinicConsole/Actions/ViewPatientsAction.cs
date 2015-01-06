using System;
using Feonufry.CUI.Actions;
using ClinicLibrary.Repositories;
using ClinicLibrary.DomainModel;

namespace ClinicLibrary.Actions
{
    public class ViewPatientsAction : IAction
    {
        private readonly IRepository<Patient> _patientRepository;

        public ViewPatientsAction(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void Perform(ActionExecutionContext context)
        {
            Console.Clear();
            Console.WriteLine("Patients:\n");

            foreach (var patient in _patientRepository.AsQueryable())
            {
                Console.WriteLine("{0}", patient.Name);
            }
        }
    }
}