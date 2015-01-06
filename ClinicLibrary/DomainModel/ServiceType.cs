
namespace ClinicLibrary.DomainModel
{
    public class ServiceType : Entity
    {
        private string _name;
        private string _code;
        private decimal _cost;

        public ServiceType()
        {
        }

        public ServiceType(string name, string code, decimal cost)
        {
            _name = name;
            _code = code;
            _cost = cost;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Code
        {
            get { return _code; }
        }

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}
