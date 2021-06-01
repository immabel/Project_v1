using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class RequestToCreate
    {
        public readonly int id;
        public string HospitalName { get; protected set; }
        public string Address { get; protected set; }
        public string Country { get; protected set; }
        public string SubmitterFirstName { get; protected set; }
        public string SubmitterLastName { get; protected set; }
        public string Email { get; protected set; }
        public DateTimeOffset DateOfCreation { get; protected set; }

        public RequestToCreate(
            int id,
            string hospitalName,
            string address,
            string country,
            string submitterFirstName,
            string submitterLastName,
            string email)
        {
            this.id = id;
            HospitalName = hospitalName;
            Address = address;
            Country = country;
            SubmitterFirstName = submitterFirstName;
            SubmitterLastName = submitterLastName;
            Email = email;
            DateOfCreation = DateTimeOffset.UtcNow;
        }

        public override string ToString() => $"ID: {id}\n" +
            $"HospitalName: {HospitalName}\n" +
            $"Address: {Address}\n" +
            $"Country: {Country}\n" +
            $"SubmitterFirstName: {SubmitterFirstName}\n" +
            $"SubmitterLastName: {SubmitterLastName}\n" +
            $"Email: {Email}\n" +
            $"DateOfCreation: {DateOfCreation.ToString("g")}";
    }
}
