﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Doctor : User
    {
        protected List<Patient> patients;
        public string Position { get; protected set; }
        public bool OnHoliday { get; protected set; }
        public int Experience { get; protected set; }
        public string Description { get; protected set; }
        public Schedule Schedule { get; protected set; }

        public Doctor(
            string id,
            string fName,
            string lName,
            string email,
            string password = null,
            string position = null,
            bool onHoliday = false) : base(id, fName, lName, Rolename.DOCTOR, email, password)
        {
            Position = position;
            OnHoliday = onHoliday;
        }

        public void AddAppointment(Appointment appointment, Patient patient)
        {
            if (!HasPatient(patient))
                AddPatient(this, patient);
            patient.AddAppointment(this, appointment);
        }

        public Patient GetPatientInfoById(string id)
        {
            return patients
                .Where(pat => pat.Id.Equals(id))
                .FirstOrDefault();
        }

        public Patient GetPatientInfoByEmail(string email)
        {
            return patients
                .Where(pat => pat.Email.Equals(email))
                .FirstOrDefault();
        }

        public void AddPrescription(Prescription prescription, string patientId)
        {

        }

        public void AddProductToPrescription(Product product, Patient patient)
        {

        }

        public void SetSchedule(Schedule schedule) => Schedule = schedule;

        public void AddScheduleDays(string[] days)
        {
            for (int i = 0; i < days.Length; i++)
                Schedule += days[i];
        }

        public void RemoveScheduleDays(string[] days)
        {
            for (int i = 0; i < days.Length; i++)
                Schedule -= days[i];
        }

        public void AddPatient(User user, Patient patient)
        {
            if (user.IsDoctorOrHigher())
                patients.Add(patient);
            else
                throw new Exception("No rights");
        }

        public bool HasPatient(Patient patient) => patients.Contains(patient);

        public override string ToString() => $"Rolename: {roleName}, Name: {FirstName} {LastName}\nEmail {Email}\n" +
            $"Position: {Position}\nExperience: {Experience} years\nDescription: {Description}";
    }
}
