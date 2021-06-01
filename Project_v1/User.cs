using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class User
    {
        private readonly string id;
        protected readonly string roleName;
        protected string password;
        protected readonly string email;
        public string Email { get { return email; } }
        public string Id { get { return id; } }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public User(
            string id,
            string firstName,
            string lastName,
            string roleName,
            string email,
            string pass)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            this.roleName = roleName;
            this.email = email;
            password = "giggle17";
        }

        public bool IsAdminOrHigher() => roleName.Equals(Rolename.ADMIN);
        public bool IsHospitalAdminOrHigher() => (roleName.Equals(Rolename.ADMIN) || roleName.Equals(Rolename.HOSPITAL_ADMIN));
        public bool IsDoctorOrHigher() => (roleName.Equals(Rolename.ADMIN) || roleName.Equals(Rolename.HOSPITAL_ADMIN) || roleName.Equals(Rolename.DOCTOR));
        public virtual void DisplayInfo() => Console.WriteLine(ToString());
    }
}
