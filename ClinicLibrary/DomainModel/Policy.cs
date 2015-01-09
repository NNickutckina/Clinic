using System.Collections.Generic;

namespace ClinicLibrary.DomainModel
{
    public class Policy : Entity
    {
        public Policy()
        {
        }

        public Policy(string series, string number, Insurance insurance, 
            List<ServiceType> serviceList, Patient patient)
        {
            Series = series;
            Number = number;
            Insurance = insurance;
            ServiceList = new List<ServiceType>(serviceList);
            Patient = patient;
        }

        public string Series
        {
            get;
            set;
        }

        public string Number
        {
            get;
            set;
        }

        public virtual Insurance Insurance
        {
            get;
            set;
        }

        public virtual List<ServiceType> ServiceList
        {
            get;
            set;
        }

        public virtual Patient Patient
        {
            get;
            set;
        }
    }
}
