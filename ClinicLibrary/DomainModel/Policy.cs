using System.Collections.Generic;

namespace ClinicLibrary.DomainModel
{
    public class Policy : Entity
    {
        private string _series;
        private string _number;
        private Insurance _insurance;
        private List<ServiceType> _serviceList;
        private Patient _patient;

        public Policy(string series, string number, Insurance insurance, 
            List<ServiceType> serviceList, Patient patient)
        {
            _series = series;
            _number = number;
            _insurance = insurance;
            _serviceList = serviceList;
            _patient = patient;
        }

        public string Series
        {
            get { return _series; }
        }

        public string Number
        {
            get { return _number; }
        }

        public Insurance Insurance
        {
            get { return _insurance; }
        }

        public List<ServiceType> ServiceList
        {
            get { return _serviceList; }
        }

        public Patient Patient
        {
            get { return _patient; }
        }
    }
}
