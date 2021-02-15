using System;

namespace MyCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager cm = new CommonManager("John");
            Majordomo md = new Majordomo("Frank");
            GeneralManager gm = new GeneralManager("Mary");

            cm.SetSuperior(md);
            md.SetSuperior(gm);

            Request request = new Request();
            request.RequestType = RequestType.Leave;
            request.RequestContent = "Max takes a leave";
            request.Number = 1;
            cm.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = RequestType.Leave;
            request2.RequestContent = "Max takes a leave";
            request2.Number = 4;
            cm.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = RequestType.Raise;
            request3.RequestContent = "Max wants to get raise";
            request3.Number = 500;
            cm.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = RequestType.Raise;
            request4.RequestContent = "Max wants to get raise";
            request4.Number = 1000;
            cm.RequestApplications(request4);

            Console.Read();
        }
    }
}
