using System;
using System.Collections.Generic;
using System.Collections;

namespace ClinicLibrary.DomainModel
{
    public class Visit : Entity
    {
        public Visit()
        {
        }

        public Visit(DateTime dateTime, string description,
                     Doctor doctor, Policy policy)
        {
            DateTime = dateTime;
            Status = VisitStatus.Planned;
            Description = description;
            Doctor = doctor;
            Policy = policy;
            Services = new List<Service>();
        }

        public DateTime DateTime { get; set; }

        public VisitStatus Status { get; set; }

        public string Description { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        public void Close()
        {
            
        }

        public void AddService(Service service)
        {
            //throw new InvalidOperationException("...");
            Services.Add(service);
        }
}
}
