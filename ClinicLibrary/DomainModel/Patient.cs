
namespace ClinicLibrary.DomainModel
{
    public class Patient : Entity
    {
        public Patient()
        {
        }

        public Patient(string fullName)
        {
            Name = fullName;
        }

        public string Name
        {
            get; 
            set;
        }
    }
}
