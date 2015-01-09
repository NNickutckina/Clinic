
namespace ClinicLibrary.DomainModel
{
    public class Doctor : Entity
    {
        public Doctor()
        {
        }

        public Doctor(string fullName)
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