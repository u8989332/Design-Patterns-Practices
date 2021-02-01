using System;

namespace DBConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            // IFactory factory = new AccessFactory();
            IFactory factory = new SqlserverFactory();

            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment idept = factory.CreateDepartment();
            idept.Insert(dept);
            idept.GetDepartment(1);

            Console.Read();
        }
    }
}
