using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class HospitalAdmin : Admin
    {
        protected Hospital Hospital { get; private set; }
        public HospitalAdmin(
            string id,
            string fName,
            string lName,
            string email,
            Hospital hospital,
            string password = null
            ) : base(id, fName, lName, email, password, Rolename.HOSPITAL_ADMIN)
        {
            Hospital = hospital;
        }

        public void AddHospitalAdmin(HospitalAdmin hospitalAdmin)
        {

        }

        public override void AddDoctor(Doctor doctor)
        {
            
        }

        public override void AddPatient(Patient patient, Doctor doctor)
        {

        }

        public void AddAppointment(Doctor doctor, Patient patient)
        {

        }

        public override string ToString() => $"Rolename: {roleName}, Name: {FirstName} {LastName}, Email {Email}";
    }
}
