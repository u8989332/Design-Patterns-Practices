using System;

namespace ERP
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInfo u1 = new UserInfo();
            u1.GetMobileNumber();

            IUserInfo u2 = new OuterUserInfo();
            u2.GetMobileNumber();
            Console.Read();
        }
    }
}
