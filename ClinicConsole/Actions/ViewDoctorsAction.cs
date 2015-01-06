using System;
using Feonufry.CUI.Actions;
using ClinicLibrary.Repositories;
using ClinicLibrary.DomainModel;

namespace ClinicLibrary.Actions
{
    public class ViewDoctorsAction : IAction
    {
        private readonly IRepository<Doctor> _doctorRepository;

        public ViewDoctorsAction(IRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void Perform(ActionExecutionContext context)
        {
            Console.Clear();
            Console.WriteLine("Doctors:\n");

            foreach (var doctor in _doctorRepository.AsQueryable())
            {
                Console.WriteLine("{0}", doctor.Name);
            }
        }
    }
}
