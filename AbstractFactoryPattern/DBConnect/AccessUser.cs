using System;

namespace DBConnect
{
    class AccessUser : IUser
    {

        public User GetUser(int id)
        {
            Console.WriteLine("In Access, get a user by id");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("In Access, insert into a user");
        }
    }
}