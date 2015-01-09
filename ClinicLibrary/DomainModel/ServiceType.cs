
namespace ClinicLibrary.DomainModel
{
    public class ServiceType : Entity
    {
        public ServiceType()
        {
        }

        public ServiceType(string name, string code, decimal cost)
        {
            Name = name;
            Code = code;
            Cost = cost;
        }

        public string Name
        {
            get;
            set;
        }

        public string Code
        {
            get;
            set;
        }

        public decimal Cost
        {
            get;
            set;
        }
    }
}
