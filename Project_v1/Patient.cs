using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Patient : User
    {
        protected List<Appointment> appointments;
        protected List<Allergy> allergies;
        protected string BloodType { get; private set; }
        protected string Sex { get; private set; }

        public Patient(
            string id,
            string fName,
            string lName,
            string email,
            string password = null,
            string bloodType = null,
            string sex = null) : base(id, fName, lName, Rolename.PATIENT, email, password)
        {
            BloodType = bloodType;
            Sex = sex;
        }

        public void GetInfo() => Console.WriteLine(ToString());
        public override string ToString() => $"Name: {FirstName} {LastName}, Blood type: {BloodType}, Sex: {Sex}";
        public void GetLastAppointmentInfo() => appointments.Last().GetInfo();
        public string GetProducts() => appointments.Last().Prescription.GetProductsInfo();
    }
}
