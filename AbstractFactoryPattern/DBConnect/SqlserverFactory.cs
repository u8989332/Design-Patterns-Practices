namespace DBConnect
{
    class SqlserverFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlserverUser();
        }
    }
}