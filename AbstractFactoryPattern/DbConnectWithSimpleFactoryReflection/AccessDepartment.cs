using System;

namespace DbConnectWithSimpleFactoryReflection
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("In Access, get a department by id");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("In Access, insert into a department");
        }
    }
}