using System;

namespace DbConnectWithSimpleFactoryReflection
{
    class SqlserverUser : IUser
    {

        public User GetUser(int id)
        {
            Console.WriteLine("In SQL Server, get a user by id");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("In SQL Server, insert into a user");
        }
    }
}