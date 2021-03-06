using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Appointment
    {
        public readonly int id;
        public Prescription Prescription { get; protected set; }
        public string DateTimeAppointment { get; protected set; }
        public string Description { get; protected set; }

        public Appointment(string date, string description = null)
        {
            DateTimeAppointment = date;
            Description = description;
        }

        public void DisplayInfo() => Console.WriteLine(ToString());

        public override string ToString() => $"---Appointment Info---\nDate: {DateTimeAppointment}\n{Prescription.ToString()}\nDescription: {Description}";

        public void AddPrescription(Prescription prescription) => Prescription = prescription;

        public void AddProduct(Product product) => Prescription += product;

        public void RemoveProduct(Product product) => Prescription -= product;
    }
}
