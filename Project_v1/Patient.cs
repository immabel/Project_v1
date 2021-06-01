using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Patient : User
    {
        protected List<Appointment> appointments = new List<Appointment>();
        protected List<Allergy> allergies = new List<Allergy>();
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

        public override void DisplayInfo()
        {
            Console.WriteLine("~~~ Patient Info ~~~");
            base.DisplayInfo();
            GetAllergiesInfo();
            GetLastAppointmentInfo();
        }

        public override string ToString() => $"Name: {FirstName} {LastName}\nEmail: {Email}\nBlood type: {BloodType}, Sex: {Sex}";

        public Appointment GetLastAppointment() => appointments.Last();

        public void GetLastAppointmentInfo() => appointments.Last().DisplayInfo();

        public void GetAllergiesInfo() => Console.WriteLine("Allergies: " + string.Join(", ", allergies.Select(al => al.ToString())));

        public string GetProducts() => appointments.Last().Prescription.GetProductsInfo();

        public void AddAppointment(User user, Appointment appointment)
        {
            if (user.IsDoctorOrHigher())
                appointments.Add(appointment);
            else
                throw new Exception("No rights");
        }
    }
}
