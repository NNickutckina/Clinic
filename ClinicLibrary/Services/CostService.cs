using ClinicLibrary.DomainModel;

namespace ClinicLibrary.Services
{
    public class CostService
    {
        public static decimal GetVisitCost(Visit visit)
        {
            var services = visit.Services;
            decimal totalCost = 0m;
            foreach (var service in services)
            {
                totalCost += service.Cost;
            }
            return totalCost;
        }

    }
}
