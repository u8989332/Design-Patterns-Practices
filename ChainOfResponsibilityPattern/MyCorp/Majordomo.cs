using System;

namespace MyCorp
{
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == RequestType.Leave && request.Number <= 5)
            {
                Console.WriteLine($"{name}:{request.RequestContent.ToLower()} number {request.Number} is approved");
            }
            else
            {
                if(superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }
}
