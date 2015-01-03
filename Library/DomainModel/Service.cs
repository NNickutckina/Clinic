
namespace Library.DomainModel
{
    public class Service : Entity
    {
        private decimal _duration;
        private decimal _cost;
        private ServiceType _serviceType;

        public Service (decimal duration, ServiceType serviceType)
        {
            _duration = duration;
            _cost = serviceType.Cost;
            _serviceType = serviceType;
        }

        public decimal Duration
        {
            get { return _duration; }
        }

        public decimal Cost
        {
            get { return _cost; }
        }

        public ServiceType ServiceType
        {
            get { return _serviceType; }
        }
    }
}
