using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicLibrary.DomainModel;
using ClinicLibrary.Context;

namespace ClinicLibrary.Services
{
    public class DoctorService
    {
        public List<Doctor> ViewAllDoctors()
        {
            using (var context = new ClinicContext())
            {
                return context.Doctors.ToList();
            }
        }
    }
}
