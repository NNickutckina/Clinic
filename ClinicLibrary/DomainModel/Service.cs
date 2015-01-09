
namespace ClinicLibrary.DomainModel
{
    public class Service : Entity
    {
        public Service()
        {

        }

        public Service (decimal duration, ServiceType serviceType)
        {
            Duration = duration;

            Cost = serviceType.Cost;
            ServiceType = serviceType;
        }

        public decimal Duration { get; set; }

        public decimal Cost { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
