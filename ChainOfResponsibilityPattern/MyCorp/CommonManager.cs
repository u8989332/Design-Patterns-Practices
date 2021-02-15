using System;

namespace MyCorp
{
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == RequestType.Leave && request.Number <= 2)
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
