using System;
using System.Collections.Generic;

namespace ClinicLibrary.DomainModel
{
    public class Visit : Entity
    {
        private DateTime _dateTime;
        private VisitStatus _status;
        private string _description;
        private Doctor _doctor;
        private Policy _policy;
        private List<Service> _services;

        public Visit()
        {
        }

        public Visit(DateTime dateTime, string description,
                     Doctor doctor, Policy policy)
        {
            _dateTime = dateTime;
            _status = VisitStatus.Planned;
            _description = description;
            _doctor = doctor;
            _policy = policy;
            _services = new List<Service>();
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public VisitStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Doctor Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }

        public Policy Policy
        {
            get { return _policy; }
        }

        public virtual IEnumerable<Service> Services
        {
            get { return _services; }
        }

        public void Close()
        {
            
        }

        public void AddService(Service service)
        {
            //throw new InvalidOperationException("...");
            _services.Add(service);
        }
}
}
