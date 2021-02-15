using System;

namespace MyCorp
{
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType == RequestType.Leave)
            {
                Console.WriteLine($"{name}:{request.RequestContent.ToLower()} number {request.Number} is approved");
            }
            else if (request.RequestType == RequestType.Raise && request.Number <= 500)
            {
                Console.WriteLine($"{name}:{request.RequestContent.ToLower()} number {request.Number} is approved");
            }
            else if (request.RequestType == RequestType.Raise && request.Number > 500)
            {
                Console.WriteLine($"{name}:{request.RequestContent.ToLower()} number {request.Number}. I will consider it...");
            }
        }
    }
}
