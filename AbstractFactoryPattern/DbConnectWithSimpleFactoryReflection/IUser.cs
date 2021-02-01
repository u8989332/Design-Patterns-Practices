namespace DbConnectWithSimpleFactoryReflection
{
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
