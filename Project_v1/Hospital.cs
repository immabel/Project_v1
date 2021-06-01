using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Hospital
    {
        public readonly int id;
        private List<Doctor> doctors = new List<Doctor>();
        private List<HospitalAdmin> hospitalAdmins = new List<HospitalAdmin>();
        public string Name { get; protected set; }
        public string Address { get; protected set; }
        public string Country { get; protected set; }

        public Hospital(
            int id,
            string name,
            string address,
            string country)
        {
            this.id = id;
            Name = name;
            Address = address;
            Country = country;
        }

        public void AddHospitalAdmin(User user, HospitalAdmin hospitalAdmin)
        {
            if (user.IsHospitalAdminOrHigher())
                hospitalAdmins.Add(hospitalAdmin);
            else
                throw new Exception("No rights!");
        }

        public void AddDoctor(User user, Doctor doctor)
        {
            if (user.IsHospitalAdminOrHigher())
                doctors.Add(doctor);
            else
                throw new Exception("No rights!");
        }

        public bool HasHospitalAdmin(HospitalAdmin hospitalAdmin) => hospitalAdmins.Contains(hospitalAdmin);

        public bool HasDoctor(Doctor doctor) => doctors.Contains(doctor);

        public bool HasPatient(Patient patient) => doctors.Any(doc => doc.HasPatient(patient));
    }
}
