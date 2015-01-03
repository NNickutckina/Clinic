using System;
using Feonufry.CUI.Actions;
using Library.Repositories;
using Library.DomainModel;

namespace Library.Actions
{
    public class ViewServiceTypesAction : IAction
    {
        private readonly IRepository<ServiceType> _serviceTypeRepository;

        public ViewServiceTypesAction(IRepository<ServiceType> serviceTypeRepository)
        {
            _serviceTypeRepository = serviceTypeRepository;
        }

        public void Perform(ActionExecutionContext context)
        {
            Console.Clear();
            Console.WriteLine("ServiceTypes:\n");

            foreach (var serviceType in _serviceTypeRepository.AsQueryable())
            {
                Console.WriteLine("{0}", serviceType.Name);
            }
        }
    }
}