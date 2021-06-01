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
        private List<Doctor> doctors;
        private List<HospitalAdmin> hospitalAdmins;
        public string Name { get; protected set; }
        public string Address { get; protected set; }
        public string Country { get; protected set; }

        public Hospital(
            string name,
            string address,
            string country)
        {
            Name = name;
            Address = address;
            Country = country;
        }

        public void AddHospitalAdmin(User user, HospitalAdmin hospitalAdmin)
        {
            if (user.IsHospitalAdminOrHigher())
                hospitalAdmins.Add(hospitalAdmin);
            throw new Exception("No rights!");
        }
    }
}
