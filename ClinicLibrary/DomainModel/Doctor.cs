
namespace ClinicLibrary.DomainModel
{
    public class Doctor : Entity
    {
        private string _fullName;

        public Doctor(string fullName)
        {
            _fullName = fullName;
        }

        public string Name
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
    }
}