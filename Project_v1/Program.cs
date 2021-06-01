using System;

namespace Project_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestToCreate rqTC1 = new RequestToCreate(1, "Detox", "Address1", "Ukraine", "Lil", "Lacc", "lil.lacc@gmail.com");
            RequestToCreate rqTC2 = new RequestToCreate(2, "Master", "Address2", "Ukraine", "Holly", "Down", "holly.down@gmail.com");
            RequestToCreate rqTC3 = new RequestToCreate(3, "Visdom", "Address3", "Ukraine", "Bill", "See", "bill.see@gmail.com");

            Admin admin = new Admin("1", "Admin", "AdminK", "admin@gmail.com");
            admin.AddRequest(rqTC1);
            admin.AddRequest(rqTC2);
            admin.AddRequest(rqTC3);
            admin.GetAllRequestsInfo();
            admin.ApproveRequest(1);
            admin.RejectRequest(2);

            Console.WriteLine("\n");
            admin.GetAllRequestsInfo();


        }
    }
}
