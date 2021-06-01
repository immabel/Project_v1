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

        public void AddHospitalAdmin(HospitalAdmin hospitalAdmin) => Hospital.AddHospitalAdmin(this, hospitalAdmin);

        public void AddDoctor(Doctor doctor) => Hospital.AddDoctor(this, doctor);

        public void AddPatient(Patient patient, Doctor doctor)
        {
            if (!Hospital.HasDoctor(doctor))
                throw new Exception($"No such doctor in the hospital \"{Hospital.Name}\"");
            doctor.AddPatient(this, patient);
        }

        public void AddAppointment(Doctor doctor, Patient patient, Appointment appointment)
        {
            if (!Hospital.HasPatient(patient))
                AddPatient(patient, doctor);
            patient.AddAppointment(this, appointment);
        }

        public void SetDoctorSchedule(Doctor doctor, Schedule schedule)
        {

        }

        public override string ToString() => $"Rolename: {roleName}, Name: {FirstName} {LastName}, Email {Email}";
    }
}
