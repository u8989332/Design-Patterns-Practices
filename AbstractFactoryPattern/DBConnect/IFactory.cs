namespace DBConnect
{
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
