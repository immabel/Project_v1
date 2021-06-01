using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Admin : User
    {
        private static List<RequestToCreate> requestsToCreate;
        private static List<Hospital> hospitals;
        public Admin(
            string id,
            string fName,
            string lName,
            string email,
            string password = null,
            string roleName = Rolename.ADMIN) : base(id, fName, lName, roleName, email, password)
        {
            requestsToCreate = new List<RequestToCreate>();
        }

        public void ApproveRequest(int requestId)
        {
            RequestToCreate request = requestsToCreate.Find(req => req.id == requestId);
            if (request != null)
            {
                Hospital hospital = new Hospital(request.HospitalName, request.Address, request.Country);
                HospitalAdmin hospitalAdmin = new HospitalAdmin(
                    "1",
                    request.SubmitterFirstName,
                    request.SubmitterLastName,
                    request.Email,
                    hospital);
                hospital.AddHospitalAdmin(this, hospitalAdmin);
                hospitals.Add(hospital);
            }
            throw new Exception("Request with such Id does not exist!");
        }

        public void RejectRequest(int requestId) => requestsToCreate.RemoveAll(req => req.id == requestId);

        public void GetAllRequestsInfo() => requestsToCreate.ForEach(req => req.DisplayInfo());

        public void AddHospitalAdmin(HospitalAdmin hospitalAdmin, Hospital hospital)
        {
            if (hospitals.Contains(hospital))
                hospital.AddHospitalAdmin(this, hospitalAdmin);
            else
                throw new Exception("Such hospital does not exist");
        }

        public override string ToString() => $"Rolename: {roleName}, Name: {FirstName}";
    }
}
