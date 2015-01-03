
namespace Library.DomainModel
{
    public class Insurance: Entity
    {
        private string _companyName;

        public Insurance(string companyName)
        {
            _companyName = companyName;
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }
}
