using System;

namespace DBConnect
{
    class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("In SQL Server, get a department by id");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("In SQL Server, insert into a department");
        }
    }
}