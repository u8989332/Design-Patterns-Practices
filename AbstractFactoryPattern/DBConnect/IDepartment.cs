namespace DBConnect
{
    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
