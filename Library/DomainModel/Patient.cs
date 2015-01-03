
namespace Library.DomainModel
{
    public class Patient : Entity
    {
        private string _fullName;

        public Patient(string fullName)
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
