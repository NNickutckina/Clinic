
namespace ClinicLibrary.DomainModel
{
    public class Insurance: Entity
    {
        public Insurance()
        {
        }

        public Insurance(string companyName)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get;
            set;
        }
    }
}
